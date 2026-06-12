--------------------------------------------------------------------------------
-- Event Management System — Oracle schema
--
-- Reconstructed from the SQL statements executed by the C# application
-- (see src/project2/*.cs). Run this against your Oracle XE instance before
-- launching the app. Connection details are configured in
-- src/project2/App.config.
--------------------------------------------------------------------------------

-- Drop existing objects (safe to ignore "does not exist" errors on first run)
-- DROP TABLE notification CASCADE CONSTRAINTS;
-- DROP TABLE participant  CASCADE CONSTRAINTS;
-- DROP TABLE event        CASCADE CONSTRAINTS;
-- DROP TABLE admin        CASCADE CONSTRAINTS;
-- DROP SEQUENCE notification_seq;

--------------------------------------------------------------------------------
-- Admin accounts (used by the admin login screen)
--------------------------------------------------------------------------------
CREATE TABLE admin (
    username  VARCHAR2(50) PRIMARY KEY,
    password  VARCHAR2(50) NOT NULL
);

--------------------------------------------------------------------------------
-- Events
--------------------------------------------------------------------------------
CREATE TABLE event (
    event_id    NUMBER(10)   PRIMARY KEY,
    eventname   VARCHAR2(100) NOT NULL,
    event_date  DATE         NOT NULL,
    event_time  VARCHAR2(20),
    location    VARCHAR2(100)
);

--------------------------------------------------------------------------------
-- Participants registered for an event
--------------------------------------------------------------------------------
CREATE TABLE participant (
    participant_id  NUMBER(10)   PRIMARY KEY,
    event_id        NUMBER(10)   REFERENCES event(event_id),
    name            VARCHAR2(100) NOT NULL,
    email           VARCHAR2(100),
    phone           VARCHAR2(20)
);

--------------------------------------------------------------------------------
-- Notifications (notification_id is generated from a sequence)
--------------------------------------------------------------------------------
CREATE TABLE notification (
    notification_id  NUMBER(10)  PRIMARY KEY,
    participant_id   NUMBER(10)  REFERENCES participant(participant_id),
    event_id         NUMBER(10)  REFERENCES event(event_id)
);

CREATE SEQUENCE notification_seq
    START WITH 1
    INCREMENT BY 1
    NOCACHE;

--------------------------------------------------------------------------------
-- Seed data
--------------------------------------------------------------------------------
INSERT INTO admin (username, password) VALUES ('admin', 'admin');

INSERT INTO event (event_id, eventname, event_date, event_time, location)
VALUES (1, 'Tech Conference', DATE '2024-02-04', '10:00 AM', 'Main Auditorium');

COMMIT;
