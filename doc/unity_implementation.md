1. [Download](https://github.com/balandinodidonato/AM22-Procedural-Audio-for-Virtual-Environments/archive/refs/heads/main.zip) the the whole content of the repository.
2. Open the project in Unity 2021.3.5f1
3. Check that everything runs fine
4. Create a new empty object called "swingModelSound" and

    ![image](./sword-tracker.png)

    4.1. Add a "LibPd Instance" component 
    4.2. The Pd patch in the "Patch" field
    4.3. Check also the "Pipe Print To Console" box, to print incoming values in Pd.

    ![image](./SwardModel_LibPdInstace.png)

5. Select the "swordTracker" game object and

    ![image](./sword_tracker_data_stript_0.png)

    5.1. Open the SwordDataTracker Script and create a LibPdInstance object which will allow to send data to the pd patch; and, send the speed value to the Pure Data patch

    ![image](./speedTracker_code_LibPdInstance.png)

    ![image](./speedTracker_PdPatchSend.png)

    5.2. Link the swingModelSound PD instance to the sword]

    ![image](./Sword_tracker_data.png)

6. Select the "sword01" game object and

    ![image](./SwordSizeScript_01.png)

    6.1. Open the SwordSize Script and create a LibPdInstance object which will allow to send data to the pd patch; and, send the speed value to the Pure Data patch

    ![image](./speedTracker_code_LibPdInstance.png)

    ![image](./SwordSizeScript_diameterSend.png)

    6.2. Link the swingModelSound PD instance to the sword]

    ![image](./SwordSizeScript_02.png)