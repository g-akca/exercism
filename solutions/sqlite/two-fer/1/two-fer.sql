-- Schema: CREATE TABLE "twofer" ("input" TEXT, "response" TEXT);
-- Task: update the twofer table and set the response based on the input.

UPDATE twofer
SET response = "One for " || 
    CASE
        WHEN (input != "") THEN input
        ELSE "you"
    END
    || ", one for me.";