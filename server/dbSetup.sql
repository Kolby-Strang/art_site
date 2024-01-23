CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key', createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', name varchar(255) COMMENT 'User Name', email varchar(255) COMMENT 'User Email', picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS sculptures (
    id INT UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT, createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', name VARCHAR(255) NOT NULL, description VARCHAR(255) NOT NULL, year INT UNSIGNED NOT NUll, price INT UNSIGNED, isLarge BOOLEAN NOT NULL
) default charset utf8;

CREATE TABLE IF NOT EXISTS images (
    id INT UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT, createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', imageUrl VARCHAR(1000) NOT NULL
) default charset utf8;

CREATE TABLE IF NOT EXISTS sculptureImages (
    id INT UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT, createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', sculptureId INT UNSIGNED NOT NULL, imageId INT UNSIGNED NOT NULL, FOREIGN KEY (sculptureId) REFERENCES sculptures (id) ON DELETE CASCADE, FOREIGN KEY (imageId) REFERENCES images (id) ON DELETE CASCADE
) default charset utf8;

INSERT INTO
    sculptures (
        name, description, year, price, isLarge
    )
VALUES (
        "Pieces Of Me", "Steel Sculpture", 2021, 1800, 1
    );

INSERT INTO
    images (imageUrl)
VALUES (
        "https://yzcvxjdmcmvriilyesrf.supabase.co/storage/v1/object/public/images/pieces-of-me/1"
    );

INSERT INTO sculptureImages (sculptureId, imageId) VALUES (1, 2)