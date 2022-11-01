A Unity-based sample application that showcases Scene Understanding on HoloLens 2. When this sample is deployed on a HoloLens, it will show the virtual representation of your real environment. 


### Running on HoloLens 2

To run this sample on a HoloLens 2:

1. Open the SceneUnderstanding Sample Scenes under **Assets\\SceneUnderstanding\\Examples** - Scenes are in the **Placement**, **NavMesh** and **Understanding** folders
2. Select the **SceneUnderstandingManager** game object and make sure that **Query Scene From Device** is selected on the **SceneUnderstandingManager Component** in all Scenes
3. Go to **File > Build Settings** and select **Build > UWP**. Once the build completes successfully, a log indicating this will show up in the output console.
4. Navigate to the **UWP** folder under root and open 'Scene Understanding.sln' in Visual Studio.
5. Right-click on the 'Scene Understanding (Universal Windows)' project and click on 'Publish' --\> 'Create App Packages'.
6. Run through the wizard and wait for building and packaging to complete.
7. The built app package should be at **UWP\\AppPackages\\Scene Understanding\\Scene Understanding\__\\Scene Understanding\__.\[appx|msix|appxbundle|msixbundle\]**
8. Deploy the package to a HoloLens 2. Ensure you build your application using **ARM64**.
9. Launch the 'Scene Understanding' app from the 'All Apps' list on the HoloLens 2!
