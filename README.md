# windows-video-player
This repository consists of Windows desktop media player and an Arduino project that will send commands to the desktop application

### Media Player
The C# project solution is located in /WindowsVideoPlayer folder
  #### Build
    Just open the solution and choose Realease profile and build
  #### Configuration
    In the output folder the is an App.config (debug) or VideoPlayer.exe.config (Release) file.
    Thru this file you can specify properties such as main window size and location, also you can specify all the additional video windows.
    Please note, after starting the application no change is will take effect any more.
    
    ##### Examples and Playground
      - There are some sample videos, if you would like to use them put full path in the config file /SampleVideos 
      - In the configuration you have ShowControls property, when enabled it will show some simple controls on top of the window
