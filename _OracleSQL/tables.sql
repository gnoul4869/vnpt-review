CREATE TABLE OFFICE (
    ID CHARACTER(5),
    NAME VARCHAR2(50),
    NOTE VARCHAR2(200),
    FATHER_ID CHARACTER(5),
    ACTIVE NUMBER(1),
    CREATED_AT DATE DEFAULT CURRENT_TIMESTAMP,
    UPDATED_AT DATE DEFAULT CURRENT_TIMESTAMP,
    -- 
    PRIMARY KEY (Id)
);
-- 
CREATE TABLE REVIEW (
    ID CHARACTER(64),
    OFFICE_ID CHARACTER(5),
    RATING FLOAT,
    CONTENT VARCHAR2(200),
    CREATED_AT DATE DEFAULT CURRENT_TIMESTAMP,
    UPDATED_AT DATE DEFAULT CURRENT_TIMESTAMP,
    --
    PRIMARY KEY (ID),
    CONSTRAINT FK_ID
        FOREIGN KEY (OFFICE_ID) REFERENCES OFFICE (ID) ON DELETE CASCADE
);
-- SEQUENCES ----------------------------------------------------------------
CREATE OR REPLACE SEQUENCE REVIEW_SEQ 
    MINVALUE 1
    START WITH 1
    INCREMENT BY 1
    NOCACHE;
-- OFFICE's PROCEDURES ------------------------------------------------------
CREATE OR REPLACE PROCEDURE GET_PAGINATED_OFFICE
(
    P_SEARCH_VALUE IN VARCHAR2 DEFAULT NULL,
    P_PAGE_NO IN INT DEFAULT 0,
    P_PAGE_SIZE IN INT DEFAULT 10,
    P_SORT_COLUMN IN INT DEFAULT 0,
    P_SORT_DIRECTION IN VARCHAR2 DEFAULT 'ASC'
)
AS
    C1 SYS_REFCURSOR;
    V_TOTAL_COUNT INT;
    V_FIRST_RECORD INT;
    V_LAST_RECORD INT;
    V_SEARCH_VALUE VARCHAR2(255);
BEGIN
    SELECT COUNT(*) INTO V_TOTAL_COUNT FROM OFFICE;

    V_FIRST_RECORD := P_PAGE_NO * P_PAGE_SIZE + 1;
    V_LAST_RECORD := (P_PAGE_NO + 1) * P_PAGE_SIZE;
    V_SEARCH_VALUE := LTRIM(RTRIM(P_SEARCH_VALUE));

    OPEN C1 FOR
        WITH CTE_RESULTS AS
        (
            SELECT ROW_NUMBER()
            OVER(
                ORDER BY
                    CASE WHEN (P_SORT_COLUMN = 0 AND P_SORT_DIRECTION = 'ASC')
                        THEN OFFICE.ID
                    END ASC,
                    CASE WHEN (P_SORT_COLUMN = 0 AND P_SORT_DIRECTION = 'DESC')
                        THEN OFFICE.ID
                    END DESC,
                    CASE WHEN (P_SORT_COLUMN = 1 AND P_SORT_DIRECTION = 'ASC')
                        THEN OFFICE.ID
                    END ASC,
                    CASE WHEN (P_SORT_COLUMN = 1 AND P_SORT_DIRECTION = 'DESC')
                        THEN OFFICE.ID
                    END DESC
            )
            AS ROW_NUM,
            COUNT(*) OVER() AS FILTERED_COUNT,
            V_TOTAL_COUNT AS TOTAL_COUNT,
            OFFICE.ID,
            OFFICE.NAME,
            OFFICE.NOTE,
            OFFICE.FATHER_ID,
            OFFICE.CREATED_AT,
            OFFICE.UPDATED_AT
        FROM OFFICE
        WHERE NVL(V_SEARCH_VALUE, '') = ''
        OR OFFICE.NAME LIKE '%' || V_SEARCH_VALUE || '%'
        )
        SELECT * FROM CTE_RESULTS WHERE ROW_NUM BETWEEN V_FIRST_RECORD AND V_LAST_RECORD;
    DBMS_SQL.RETURN_RESULT(C1);
END;
-- 
CREATE OR REPLACE PROCEDURE GET_OFFICE_COUNT
AS
    C1 SYS_REFCURSOR;
BEGIN
    OPEN C1 FOR
        SELECT COUNT(*) FROM OFFICE ORDER BY OFFICE.ID;
    DBMS_SQL.RETURN_RESULT(C1);
END;
-- 
CREATE OR REPLACE PROCEDURE GET_ALL_OFFICE
AS
    C1 SYS_REFCURSOR;
BEGIN
    OPEN C1 FOR
        SELECT * FROM OFFICE ORDER BY OFFICE.ID;
    DBMS_SQL.RETURN_RESULT(C1);
END;
-- 
CREATE OR REPLACE PROCEDURE GET_OFFICE
    (P_ID IN CHARACTER)
AS
    C1 SYS_REFCURSOR;
BEGIN
    OPEN C1 FOR 
        SELECT * FROM OFFICE WHERE OFFICE.ID = P_ID;
    DBMS_SQL.RETURN_RESULT(C1);
END;
-- 
CREATE OR REPLACE PROCEDURE CREATE_OFFICE
(
    P_NAME IN VARCHAR2,
    P_NOTE IN VARCHAR2,
    P_FATHER_ID IN CHARACTER,
    P_ACTIVE IN NUMBER
)
AS
BEGIN
    INSERT INTO OFFICE VALUES
    (
        P_ID,
        P_NAME,
        P_NOTE,
        P_FATHER_ID,
        P_ACTIVE,
        DEFAULT,
        DEFAULT
    );
END;
-- 
CREATE OR REPLACE PROCEDURE UPDATE_OFFICE
(
    P_ID IN CHARACTER,
    P_NAME IN VARCHAR2,
    P_NOTE IN VARCHAR2,
    P_FATHER_ID IN CHARACTER,
    P_ACTIVE IN NUMBER
)
AS
BEGIN
    UPDATE OFFICE SET
        OFFICE.NAME = P_NAME,
        OFFICE.NOTE = P_NOTE,
        OFFICE.FATHER_ID = P_FATHER_ID,
        OFFICE.ACTIVE = P_ACTIVE,
        OFFICE.UPDATED_AT = DEFAULT
    WHERE OFFICE.ID = P_ID; 
END;
-- 
CREATE OR REPLACE PROCEDURE DELETE_OFFICE
    (P_ID IN CHARACTER)
AS
BEGIN
    DELETE FROM OFFICE WHERE
        OFFICE.ID = P_ID;
END;
-- REVIEW's PROCEDURE ------------------------------------------------------
CREATE OR REPLACE PROCEDURE GET_ALL_REVIEW_IN_OFFICE
    (P_ID IN CHARACTER)
AS
    C1 SYS_REFCURSOR;
BEGIN
    OPEN C1 FOR 
        SELECT DISTINCT REVIEW.ID, REVIEW.OFFICE_ID, REVIEW.RATING, 
            REVIEW.CONTENT, REVIEW.CREATED_AT, REVIEW.UPDATED_AT
                FROM REVIEW INNER JOIN OFFICE ON OFFICE.ID = P_ID;
    DBMS_SQL.RETURN_RESULT(C1);
END;
-- 
CREATE OR REPLACE PROCEDURE GET_REVIEW_IN_OFFICE
(
    P_RID IN CHARACTER,
    P_OID IN CHARACTER
)
AS
    C1 SYS_REFCURSOR;
BEGIN
    OPEN C1 FOR
        SELECT DISTINCT REVIEW.ID, REVIEW.OFFICE_ID, REVIEW.RATING, 
            REVIEW.CONTENT, REVIEW.CREATED_AT, REVIEW.UPDATED_AT
                FROM REVIEW INNER JOIN OFFICE ON REVIEW.OFFICE_ID = P_OID AND REVIEW.ID = P_RID;
    DBMS_SQL.RETURN_RESULT(C1);
END;
-- 
CREATE OR REPLACE PROCEDURE CREATE_REVIEW
(
    P_OFFICE_ID IN CHARACTER,
    P_RATING IN FLOAT,
    P_CONTENT IN VARCHAR2
)
AS
BEGIN
    INSERT INTO REVIEW VALUES
    (
        REVIEW_SEQ.NEXTVAL,
        P_OFFICE_ID,
        P_RATING,
        P_CONTENT,
        DEFAULT,
        DEFAULT
    );
END;
-- 
CREATE OR REPLACE PROCEDURE UPDATE_REVIEW
(
    P_ID IN CHARACTER,
    P_RATING IN FLOAT,
    P_CONTENT IN VARCHAR2
)
AS
BEGIN
    UPDATE REVIEW SET
        REVIEW.RATING = P_RATING,
        REVIEW.CONTENT = P_CONTENT,
        REVIEW.UPDATED_AT = DEFAULT
    WHERE REVIEW.ID = P_ID; 
END;
-- 
CREATE OR REPLACE PROCEDURE DELETE_REVIEW
    (P_ID IN CHARACTER)
AS
BEGIN
    DELETE FROM REVIEW WHERE
        REVIEW.ID = P_ID;
END;


