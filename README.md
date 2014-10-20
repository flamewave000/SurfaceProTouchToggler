SurfaceProTouchToggler
======================

This application is designed to enable/disable a single device on a Windows 8/8.1 computer. It is intended to toggle the touch screen device on or off, but by changing the target Hardware ID, the program can target any device.

Troubleshooting
===============
In the event of this program not successfully toggling the touch screen device, the predefined hardware ID may be wrong. To fix, follow these steps:

1.	Open app settings (Right Click Tray Icon -&gt; Options -&gt; Settings)
2.	Click the \"Devices\" button. This should open a separate windows containing a list of Hardware IDs and their related devices.
3.	Find the touch device (or any device you wish to toggle). It is usually labeled \"HID-compliant touch screen\".
4.	Copy the hardware ID (the portion to the left of the label). It should look similar to the following: \"HID\\NTRG0001&amp;COL02\\5&amp;63F74D3&amp;1&amp;0001\".
5.	Close the device list window and then click the \"Edit Hardware ID\" button.
6.	Clear the field and paste the copied hardware id into the text box.
7.	Click \"Save\" and close the window.
The hardware id may not always work as it is displayed. You may need to remove some of the end of the ID. In the case of the default touch screen ID \"HID\\NTRG0001&amp;COL02\\5&amp;63F74D3&amp;1&amp;0001\", I actually only use \"HID\\NTRG0001&amp;COL02\". Anything more and it fails.

Note: This program can be used to enable and disable other types of devices by adjusting the Hardware ID to any other device in these settings

License
=======
Copyright (C) 2014  flamewave000
This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
You should have received a copy of the GNU General Public License along with this program.  If not, see &lt;http://www.gnu.org/licenses/&gt;
