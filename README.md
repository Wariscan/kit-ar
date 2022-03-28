Fast kit for AR app creation

### AR ImageTracker
This scene (Assets > AR Image Scene > ImageTracker) contains all the objects we need for ImageTarget based AR.


**To add more ImageTarget:**
1. Go to the top menu, GameObject > Create Empty.
2. One new GameObject will be created on Hierarchy. Rename it to ImageTarget.
3. While this new ImageTarget is still selected, go to Inspector and Add Component.
4. Add NY Image Tracker script.
5. On Inspector, reset its Position to (0, 0, 0).
6. On Inspector, add your ImageTarget to Tracker Image.
7. Scale to its Physical Size (example 0.3 for A4 size ImageTarget).
8. Relocate ImageTarget Position to the appropriate location.


**To add 3D model to ImageTarget:**
1. Any object related to a specific ImageTarget should be placed as a child of Object Container.
2. Drag-and-drop 3D Object Container from Assets/AR Image/Prefabs to new ImageTarget under Hierarchy. 3D Object Container should be a child of ImageTarget.
3. Select that 3D Object Container, right-click on it and select Prefab > Unpack Completely. This will make this 3D Object Container separated from Prefab. 
4. Expand 3D Object Container and delete Cube. 
5. To add a 3D model, drag-and-drop FBX or OBJ files from Project into Object Container. 
6. Select ImageTarget again (parent of 3D Object Container), go to Inspector, Add Component. Add Hide And Show Object script. Drag-and-drop 3D Object Container to Object To Hide Show box. This will allow AR content in this ImageTarget dismissed from the screen if ImageTarget is lost.
7. Select ImageTarget, go to Inspector, Add Component. Add NY Image Tracker Event Handler.
8. Select the ImageManager object and hit Update Library.


**To add Video to ImageTarget:**
1. Drag and drop one of the video Prefabs from Assets/Audio Video/Prefabs/For AR Image to ImageTarget.
a. Video Ctrl on Image
b. Video Ctrl on Screen
c. Video GreenScreen
2. Select Video prefabs (child of ImageTarget), right-click on it and select Prefab > Unpack Completely. This will make this Video Prefabs separated from Prefab. Now we are free to change this object without effect the Prefab.
3. Select Video object. Under Inspector, assign our Video Clip to the Video Player component.
4. Select ImageTarget again (parent of Video), go to Inspector, Add Component. Add Hide And Show Object script. Drag-and-drop Video object to Object To Hide Show box. This will allow video content in this ImageTarget dismissed from the screen if ImageTarget is lost.
5. Select ImageTarget, go to Inspector, Add Component. Add NY Image Tracker Event Handler.
6. Select the ImageManager object and hit Update Library.
