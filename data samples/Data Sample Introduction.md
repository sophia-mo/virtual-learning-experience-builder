# Data Sample Introduction

Our program does not have many data samples. In our project, the primary focus lies in developing and refining the 3D operation logic for our Virtual Academy High-Fidelity Prototype, rather than extensive art production. This unique emphasis on functionality over aesthetics naturally leads to a reduced need for a large quantity of data sample files. Here's why:

1. **Functional Emphasis:** Our project prioritizes the development of robust 3D operation logic to ensure that the Virtual Academy Prototype functions seamlessly and effectively for users. Therefore, our main focus is on creating and refining the underlying mechanics and interactions within the prototype, rather than generating a wide variety of visual assets.

2. **Prototype Demonstration:** The data sample files included in our repository are primarily intended for demonstration purposes, illustrating key functionalities and features of the prototype. Since our emphasis is on showcasing the logic and mechanics of the prototype, a smaller selection of sample files suffices to effectively convey its capabilities to stakeholders and users.

3. **Iterative Development:** Our project may follow an iterative development approach, where we continuously iterate on the 3D operation logic based on feedback and testing results. In such a scenario, a smaller set of data sample files initially allows us to quickly iterate and make adjustments as needed, without being encumbered by an extensive collection of assets. 

## File Format Compatibility

To ensure seamless integration with our High-Fidelity Prototype, please note that only `png` and `jpg` file formats are accepted. Make sure all sample images adhere to these formats for optimal performance.

### Sample Images

Here lies sample images can be used to import to the High-Fidelity Prototype.

On windows, put files in `%USERPROFILE%\Pictures\VirtualAcademy` (Create them if they does not exist.)

On Linux, put files in `~/Pictures/VirtualAcademy`.

On MacOS, they should be in Picture Library or the same location as in Linux.

The data sample folder contains a variety of sample images that can be imported into the High-Fidelity Prototype. These images are carefully selected to represent various elements and scenarios within the virtual academy environment.

## Usage Guidelines
To access the digital prototype, please download the [ZIP High Fidelity Prototype](https://github.com/SWEN90009-2024/VL-RedBack/blob/main/prototypes/high%20fidelity/VirtualAcademy-win32-x86_64.7z).
Unzip it and open ``VL-Hi-Fi-Prototype.exe``

- **Importing Images:**
  Follow the instructions provided in the prototype's user interface to import sample images into the virtual academy environment.

- **File Naming Convention:**
  Maintain a consistent and descriptive naming convention for sample image files to ensure clarity and organization.

## Simulation Tasks

### Scenario 1
As a teacher,
I want to edit the object in the 3D environment,
So that I can make this 3d environment fit into what I'm teaching.

**Task:**  Choose to login as a teacher at the home scene. Select the exist "classroom" environment and click "Edit", select the default character and click "Enter". Place a cube into the environment from the left asset panel. Use ethier drag-and-drop or enter specific value in the right panel to set the size of the cube to "x:5, y:5, z:5". Move the cube "5" meters along the X-axis direction by adding 5 in x position. Rotate the cube "30" degrees around the Y-axis direction by and 30 in y rotation.

### Scenario 2
As a teacher,
I want to add a image into the 3D environment,
So that I can make this 3d environment fit into what I'm teaching.

**Task:**  In the environment edition scene, add the image "pexels-photo-12163946.jpg" from data samples folder to asset by click the "+" button at the left asset panel. Drag it into the environment and attach it to the blackboard in the classroom. Save the changes from the top-left menu.

### Scenario 3
As a teacher,
I want to create a new 3D environment,
So that I can my own 3D environment.

**Task:** At the evironment selection scene, create a new Environment by click the "+" button. Name the environment as "First Environment", and creating a new character by click the "+" button in the character selection scene, name it as "First Character".

### Scenario 4
As a teacher,
I want to edit the character's attributes,
So that I can limits the ability of the character in this 3d environment.

**Task:** in the character selection scene, select "First Character" you created and click "Edit". at the right panel, set its height to "1.5" m and jump height to "0.5" m and speed to "2" km/h. You can rename it as "New Charecter" from the "save as" in the menu.

### Scenario 5
As a student,
I want to join in the environment and walk freely in this environment,
So that I can understand the content of this lecture.

**Task:** select to login as Student at the home page. select the "classroom" environment and click "Enter" to join in. Move around in the environment use keyboard key "WASD". Use the mouse to control the viewpoint. Press "F" close to the picture to watch it.

