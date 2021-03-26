CREATE DATABASE faacbase;
USE faacbase;
CREATE TABLE faacdata(state CHAR(30),
						january SMALLINT,
                        february SMALLINT,
                        march SMALLINT,
                        april SMALLINT,
                        may SMALLINT,
                        june SMALLINT,
                        july SMALLINT,
                        august SMALLINT,
                        september SMALLINT,
                        october SMALLINT,
                        november SMALLINT,
                        december SMALLINT,
                        total SMALLINT);
SELECT * FROM faacdata; -- Import wizard was used from here to convert CSV into database.