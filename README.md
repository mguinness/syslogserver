# Syslog Server
A basic syslog server for Windows.  Can be used as a log collector for [Syslog.Framework.Logging](https://github.com/mguinness/syslog-framework-logging) package.

## Introduction
This application was developed as a very simple syslog server that runs under Windows.  It is not meant to compete with products like Kiwi Syslog Server, but rather to be used as a lightweight server for development purposes.  It runs as a standalone application (not installed as a service) and all logs are kept in memory and are	not saved to a database.

## Operation
This application requires no installation or configuration and will run on any version of Wnidows that has .NET Framework 4.5.2 installed.  Once running it will capture any syslog events received on UDP port 514.  These events are displayed in a grid where the most recent are at the top and the selected row will display detail in the lower portion which is useful when there is a lot of text content.

An additional useful feature is that these events can also be filtered by either facility, severity, content or hostnames.  This can help show events to those that are of interest to you.  Both content and hostname filters allow you to specify multiple strings (using newlines) to show an event if the field contains any of those strings specified.  Copy logs will copy all events being displayed to the clipboard and flush logs will clear any existing captured events.