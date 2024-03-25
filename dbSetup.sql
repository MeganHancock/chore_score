CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key', createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', name varchar(255) COMMENT 'User Name', email varchar(255) COMMENT 'User Email', picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE chore (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, name VARCHAR(100) NOT NULL, lengthInMinutes INT NOT NULL, requiresChemical BOOLEAN DEFAULT false, requiresTool BOOLEAN DEFAULT false, completed BOOLEAN DEFAULT false
)