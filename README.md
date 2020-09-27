# ProjectEsky-6DOF-HandAligner-Interactive

Attached is the 6DOF/Leapmotion interactive Hand-Aligner that enables Esky to have the precise
Between-Sensor Calibrations!

First, follow the same instructions for project setup found here:
https://github.com/HyperLethalVector/ProjectEsky-UnityIntegration 

With one exception, you're loading up the files in Scenes/LMHandCalibration.unity first
Then Scenes/6DOFHandCalibration.unity for the ZED camera calibration

Calibration is easy and straightforward

1) (LM)) hold your Right hand in front of the display, a white virtual hand should appear

2) Hold space, this will freeze the virtual hand

3) While holding space, move your right hand, so it matches the virtual hand image

4) Release space when your real hand, and the virtual hand lines up nicely

5) Repeat 1-4 several times, until it prompts you to save

6) Hopefully the calibration works well, if it doesn't you can use the arrow keys to adjust further, or restart using 'r'

7) If it does work, just hit the 's' button

8) (6DOF)  Same story for steps 1-7, except you're using the video texture displayed on the unity screen for alignment.


