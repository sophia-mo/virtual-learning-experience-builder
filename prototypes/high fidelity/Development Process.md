# Process of Designing the High Fidelity Prototype

## Objective
Our goal was to create a detailed and interactive version of our Virtual Learning Experience Builder (VLEB) using Unity, showing its advanced features and how users would interact with it in real scenarios.

## Choice of Technique
After group discussion, we decided to use Unity 3D to build our high-fidelity prototype. Choosing Unity over platforms like Figma was strategic for several reasons:
- **Interactive Capabilities:** Although Figma is excellent for static high-fidelity UI designs, Unity provides the ability to create fully interactive and immersive environments. This is crucial for simulating realistic educational scenarios in VR and AR.
- **3D Support:** Unity's robust 3D development capabilities are essential for building comprehensive virtual learning environments, far surpassing the 2D limitations of Figma.
- **Scalability and Performance:** Unity offers greater scalability for complex projects, supporting a wide range of functionalities and optimizations that are critical for educational software, such as media import.
- **Platform Flexibility:** Unity allows deployment across multiple platforms (web, mobile, desktop, VR/AR headsets), which is vital for educational programs intended for broad accessibility. The client can easily execute our .exe file.

## Transition from Low to High Fidelity
Transitioning from slides to Unity allowed for a more dynamic prototype, leveraging Unity's capabilities to simulate realistic educational environments.
- **Applied Recommendations of Low-fidelity Prototype Feedback:** The feedback of low-fidelity prototype is documented and addressed in [Development Process](https://github.com/SWEN90009-2024/VL-RedBack/blob/main/prototypes/low%20fidelity/Development%20Process.md). These changes are implemented in the high-fidelity prototype.
- **Enhanced Interactivity:** Leveraged Unity's tools for a highly interactive interface.
- **Complex Functionality Implementation:** Utilized Unity's advanced scripting for intricate feature implementation.
- **Graphical Fidelity:** Employed high-quality graphics to enhance visual appeal and engagement.

## Key Features of the High Fidelity Prototype
- **Realistic Prototype:** Closer to what the final version would look like.
- **Intuitive User Interface:** Easy for educators with minimal technical skills.
- **Customizable Elements:** Extensive library for diverse module creation.
- **Interactive Elements:** Include navigation as click-through. Integrated interactive media to boost engagement.


## Program Development Progress
### Feedback Integration
Addressed feedback from low-fidelity testing:
- **User Input Simplicity:** Simplified data input processes.
- **Enhanced Navigation Logic:** Improved intuitiveness and reduced error potential.

### Coding Progress
UI development follows the [Design Guideline](https://github.com/SWEN90009-2024/VL-RedBack/blob/main/ui/Design%20Guideline.md).
The coding work is illustrated in the following images.
#### Project Code Structure
![image](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/f4510bde-e836-4364-9512-9a008bdcc21a)
#### Project Operation Logic Code
![Code-CreatorLogic](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/5ecaafcf-9220-4df2-9685-d9698ec5cc9a)
#### Scene Construction
![Unity-Building-A-Room](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/71dacb94-43a8-41ba-9565-d289ad691908)
#### Making Shaders
![Unity-Making-A-Shader](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/a1c2696d-65d6-405a-b7a4-2e448fd09425)


### Testing and Quality Assurance
- **Comprehensive Testing:** Ensured all functionalities worked seamlessly. No bugs hinder user operation.
- **Performance Optimization:** Make sure the program can run smoothly.
- **Iteration:** Demonstrate the prototype to the client, adjust the program based on client's feedback.

### Finalization and Documentation
- **Documentation:** Detailed user guides prepared.
- **Preparation for Deployment:** Adjusted for deployment readiness and scalability.

### Final Version of High Fidelity Prototype
#### Main Menu
![屏幕截图 2024-06-04 163041](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/bbc91a8e-f9a1-4c55-8ab6-539dac1ede1b)
#### Environment Creation / Selection
![屏幕截图 2024-06-04 163058](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/55b9cb4a-06a8-424d-8355-0f2a018ef64c)
#### Character Selection
![屏幕截图 2024-06-04 164024](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/c06cbaf7-c5ec-4e6c-b842-264e00f1fcdd)
#### Edit Character
![屏幕截图 2024-06-04 163357](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/eba034fe-d5a0-4437-982e-4a55718aed23)
#### Edit Environment
![屏幕截图 2024-06-04 163211](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/cc5d3e66-b8dc-4e25-bf0a-f89bff1b0e3b)
#### Set Interaction
![屏幕截图 2024-06-04 164428](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/b5367b64-bec8-4dd5-a856-f6e4bbefb863)
#### Play Phase
![屏幕截图 2024-06-04 163535](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/4a2d22e9-a44d-4543-acf1-bd3d8d64d72e)
#### Play Phase (Instruction Hided)
![屏幕截图 2024-06-04 163606](https://github.com/SWEN90009-2024/VL-RedBack/assets/101912029/972d5014-86e3-491d-9dc2-83a34f5f25fd)

## Future Plan
Based on the feedback received from the client meeting on May 29th, 2024, the future plan for our high fidelity prototype will include the following enhancements:

1. **Simplify Teacher View:**
   - **Action:** Reduce clutter in the object information panel.
   - **Action:** Implement a toggle for advanced settings to show/hide detailed parameters.

2. **Enhance Object Interaction:**
   - **Action:** Develop a grid-based movement and object snapping system to simplify object placement.
   - **Action:** Establish a decision tree for object parenting and movement to manage relationships between objects.

3. **Adjust Character Customization:**
   - **Action:** Move character customization settings to the teacher view for centralized control.
   - **Action:** Ensure teacher control over character customization to maintain consistency in the virtual environment.

4. **Include Quiz Functionality:**
   - **Action:** Develop a prototype or mock-up for quiz interactions to enhance interactivity.
   - **Action:** Implement quiz functionalities using a similar interaction method as images, with pop-up windows for quiz questions.

These improvements aim to address the specific feedback provided by the client, ensuring that the high fidelity prototype aligns closely with their expectations and requirements. The team will work on incorporating these enhancements into the final version of the prototype, which is scheduled for submission by the following week. Additionally, the team will prioritize refining the user interface and adding quiz functionalities to ensure completeness and usability.

## Appendix
The demonstration video of high-fidelity prototype can refer to this link:
[High Fidellity Prototype Demo](https://unimelbcloud-my.sharepoint.com/personal/keangl_student_unimelb_edu_au/_layouts/15/stream.aspx?id=%2Fpersonal%2Fkeangl%5Fstudent%5Funimelb%5Fedu%5Fau%2FDocuments%2FSRA%2FMeeting%20Recordings%2FClient%20Meeting%2D2024%2D05%2D29%2Emp4&ga=1&referrer=StreamWebApp%2EWeb&referrerScenario=AddressBarCopied%2Eview%2E9f89f721%2Dec53%2D49cf%2D952b%2D8e3cfe9ea49f)
