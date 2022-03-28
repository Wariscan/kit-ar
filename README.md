# kit-ar
A kit for quick AR app creation and deployment. 

### AR ImageTracker
This scene (Assets > Scenes > AR ImageTracker) contains all the object we need for
ImageTarget based AR.


**To add more ImageTarget:**
1. Go to the top menu, GameObject > Create Empty.
2. One new GameObject will be created on Hierarchy. Rename it to ImageTarget.
3. While this new ImageTarget is still selected, goto Inspector and Add Component.
4. Add NY Image Tracker script.
5. On Inspector, reset its Position to (0, 0, 0).
6. On Inspector, add your ImageTarget to Tracker Image.
7. Scale down its Physical Size (example 0.3 for A4 size ImageTarget).
8. Relocate ImageTarget Position to appropriate location.
9. Select our new ImageTarget. Go to the top menu, GameObject > Create Empty Child. Rename it to Object Container.
10. While Object Container is still selected, goto Inspector and Add Component.
11. Add Box Collider. Resize Scale to smaller than ImageTarget’s scale (example 0.2, 0.2, 0.2).
12. Select ImageTarget, goto Inspector, Add Component. Add Hide And Show Object script. Drag-and-drop its Object Container to Object To Hide Show box.
13. Select ImageManager GameObject and hit Update Library.

**To add 3D model to ImageTarget:**
1. Any object related to specific ImageTarget should be placed as a child of Object
Container.
2. To add a 3D model, drag-and-drop FBX or OBJ files from Project into Object Container.


**To add Video to ImageTarget**
1. Any object related to specific ImageTarget should be placed as a child of Object
Container.
2. Select Object Container, right-click > 3D Object > Quad. And rename it to Video Frame.
3. Rotate and reposition Quad accordingly.
4. Create Material for Quad. In any folder in Project, click on Assets > Create > Material.
5. Select new created Material. In Inspector, change Albedo colour to black.
6. Drag-and-drop this new Material onto Video Frame.
7. Select Video Frame. In Inspector, Add Component. Add Video Player and select your video file. Remain Render Mode as Material Override.
