Contract Monthly Claim System (Prototype)
Overview

This project is a prototype for a Contract Monthly Claim System made with ASP.NET Core MVC.
It is not fully functional, it only shows how the system would look like. The purpose is to demonstrate the design and layout.

Features

Lecturer (Buhle) can log in and see:

Upload Claim button

Check Claim button

Example claims (pending and approved)

Programme Coordinator (Lukas) can log in and see all claims and mark them as approved or rejected (visual only).

Academic Manager (Michael) can log in and see all claims and also approve or reject them (visual only).

If both coordinator and manager approve → claim shows as approved.

If one rejects → claim shows as rejected.

Project Structure

Controllers → HomeController

Models → Claim model (basic data for claims)

Views → Pages for Lecturer, Coordinator, and Manager

Shared → Layout with navigation bar

How to Run

Open the project in Visual Studio.

Run the project with dotnet run or the play button in Visual Studio.

Users

Lecturer: Buhle

Programme Coordinator: Lukas

Academic Manager: Michael

(For now there is no real login, just pages with names.)

Notes

This is only a prototype.

Claims, approvals, and rejections are just examples.

Later the system can be connected to a real database and authentication.
