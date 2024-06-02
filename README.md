# UE5.3-PixelStreaming-CrashSolution
maybe a solution to the problem that UE5.3 projects are prone to crashing when using PixelStreaming

In UE 5.3, using PixelSteaming may cause a crash due to memory leak after running for a certain period of time.  
I copy the relevant code from the engine directory and modify it according to the instructions provided in PR10637 and PR11068 on the Github.
Then i make some modifications to ensure compilation passed.  
If you encounter the same problem as me, you can try copying the code to the project's plugins directory to solve it.  
Finally, I would like to express my gratitude to zuvola and Berry.[@zuvola](https://github.com/zuvola) [@berry0511](https://github.com/berry0511)

reference:  
https://github.com/EpicGames/UnrealEngine/pull/10637  
https://github.com/EpicGames/UnrealEngine/pull/11068  
https://forums.unrealengine.com/t/includes-custom-pixelstreaming-plugin-in-project/475719/2  
https://forums.unrealengine.com/t/memory-leaks-in-pixel-streaming-5-21/1347280
