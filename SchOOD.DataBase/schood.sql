CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

START TRANSACTION;

CREATE TABLE `Users` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CalendarPath` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`Id`)
);

CREATE TABLE `Courses` (
    `Id` char(36) NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DbUserId` bigint NULL,
    CONSTRAINT `PK_Courses` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Courses_Users_DbUserId` FOREIGN KEY (`DbUserId`) REFERENCES `Users` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Rules` (
    `Id` char(36) NOT NULL,
    `Effect` smallint NOT NULL,
    `Target` char(36) NOT NULL,
    `Argument` longtext CHARACTER SET utf8mb4 NULL,
    `DbUserId` bigint NULL,
    CONSTRAINT `PK_Rules` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Rules_Users_DbUserId` FOREIGN KEY (`DbUserId`) REFERENCES `Users` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Events` (
    `Id` char(36) NOT NULL,
    `StartTime` datetime(6) NOT NULL,
    `Duration` time(6) NOT NULL,
    `Location` longtext CHARACTER SET utf8mb4 NULL,
    `Teacher` longtext CHARACTER SET utf8mb4 NULL,
    `Type` int NOT NULL,
    `DbCourseId` char(36) NULL,
    CONSTRAINT `PK_Events` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Events_Courses_DbCourseId` FOREIGN KEY (`DbCourseId`) REFERENCES `Courses` (`Id`) ON DELETE RESTRICT
);

CREATE INDEX `IX_Courses_DbUserId` ON `Courses` (`DbUserId`);

CREATE INDEX `IX_Events_DbCourseId` ON `Events` (`DbCourseId`);

CREATE INDEX `IX_Rules_DbUserId` ON `Rules` (`DbUserId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201119103523_Initial', '5.0.0');

COMMIT;

