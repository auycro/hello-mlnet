Generate Model

```
% mlnet classification --dataset "dataset/wikiDetoxAnnotated160kRows.tsv" --label-col "Label" --train-time 600
Start Training
|     Trainer                              MicroAccuracy  MacroAccuracy  Duration #Iteration                     |
|1    AveragedPerceptronOva                       0.9600         0.8312      58.3          1                     |                                                |2    SdcaMaximumEntropyMulti                     0.9553         0.8057      49.9          2                     |                                                Unable to load shared library 'lib_lightgbm' or one of its dependencies. In order to help diagnose loading problems, consider setting the DYLD_PRINT_LIBRARIES environment variable: dlopen(liblib_lightgbm, 1): image not found                                                                                                    The type initializer for 'Native' threw an exception.                                                                                                                                                                                                                                                                               ===============================================Experiment Results=================================================                                                ------------------------------------------------------------------------------------------------------------------
|                                                     Summary                                                    |
------------------------------------------------------------------------------------------------------------------
|ML Task: multiclass-classification                                                                              |
|Dataset: {app_folder}/dotnet-ml-test/dataset/wikiDetoxAnnotated160kRows.tsv      |
|Label : Label                                                                                                   |
|Total experiment time : 183.77699249999998 Secs                                                                 |
|Total number of models explored: 4                                                                              |
------------------------------------------------------------------------------------------------------------------

|                                              Top 2 models explored                                             |
------------------------------------------------------------------------------------------------------------------
|     Trainer                              MicroAccuracy  MacroAccuracy  Duration #Iteration                     |
|1    AveragedPerceptronOva                       0.9600         0.8312      58.3          1                     |
|2    SdcaMaximumEntropyMulti                     0.9553         0.8057      49.9          2                     |
------------------------------------------------------------------------------------------------------------------

Code Generated
Generated C# code for model consumption: {app_folder}/dotnet-ml-test/SampleClassification/SampleClassification.ConsoleApp
Check out log file for more information: {user_folder}/.mlnet/log.txt
Exiting ...
```
