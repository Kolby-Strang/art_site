CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key', createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', name varchar(255) COMMENT 'User Name', email varchar(255) COMMENT 'User Email', picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS sculptures (
    id INT UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT, createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', name VARCHAR(100) NOT NULL UNIQUE, description VARCHAR(1000) NOT NULL, year INT UNSIGNED NOT NUll, price INT UNSIGNED, isLarge BOOLEAN NOT NULL, coverImg VARCHAR(1000) NOT NULL
) default charset utf8;

CREATE TABLE IF NOT EXISTS images (
    id INT UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT, createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', imageUrl VARCHAR(1000) NOT NULL, sculptureId INT UNSIGNED NOT NULL, Foreign Key (sculptureId) REFERENCES sculptures (id) ON DELETE CASCADE
) default charset utf8;

INSERT INTO
    sculptures (
        name, description, year, price, isLarge, coverImg
    )
VALUES (
        "Pieces Of Me", "Steel Sculpture", 2021, 1800, 1, "https://yzcvxjdmcmvriilyesrf.supabase.co/storage/v1/object/public/images/pieces-of-me/0"
    );

INSERT INTO
    images (imageUrl, sculptureId)
VALUES (
        "https://yzcvxjdmcmvriilyesrf.supabase.co/storage/v1/object/public/images/the-sound-of-touch/0", 2
    );

SELECT sculptures.*, images.*
FROM sculptures
    JOIN images ON images.sculptureId = sculptures.id;

DELETE FROM images WHERE id = 3;

ALTER TABLE sculptures ADD COLUMN dimensions varchar(20)