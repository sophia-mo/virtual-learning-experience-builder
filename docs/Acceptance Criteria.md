# VL-RedBack Acceptance Criteria
  <table>
    <tr align="center">
      <th>Epic</th>
      <th>User Story ID</th>
      <th>User Story</th>
      <th>Given</th>
      <th>When</th>
      <th>Then</th>
    </tr>
     <tr align="center">
      <th colspan = 6></th>
    </tr>
    <tr>
      <td rowspan = 7 align="center"><b>Environmental Creation</b></td>
      <td align="center" rowspan = 2>US1.1</td>
      <td rowspan = 2><b>As a</b> teacher, <b>I want to</b> access an edit mode, <b>so that</b> I can customise the teaching environment to better suit my lesson plans</td>
      <td>There is an 'ADD' button on environment select interface</td>
      <td>I click the 'ADD' button</td>
      <td>The system change to edit mode which can create new environment</td>
    </tr>
    <tr>
      <td>There is a 'EDIT' button on environment select interface</td>
      <td>I click the 'EDIT' button</td>
      <td>The system change to edit mode which can the existing environment</td>
    </tr>
    <tr>
      <td align="center">US1.2</td>
      <td><b>As a</b> teacher, <b>I want to</b> select and import 3D elements from a resource library, <b>so that</b> I can enhance the realism and relevance of educational content</td>
      <td>There is a 'resource' button on environment edit interface </td>
      <td>I click the 'resource' button</td>
      <td>The resource folder will be opened and there are many items in different categories</td>
    </tr>
     <tr>
      <td align="center">US1.3</td>
      <td><b>As a</b> teacher, <b>I want to</b> import and utilise 3D scanned items in my virtual classroom, <b>so that</b> I can incorporate real-world elements into my designs</td>
      <td>I scanned an item and there is a 'IMPORT' button on environment edit interface</td>
      <td>I click the 'IMPORT' button and import 3D scanned items</td>
      <td>The selected items will be imported to the environment</td>
    </tr>
    <tr>
      <td align="center" rowspan = 2>US1.4</td>
      <td rowspan = 2><b>As a</b> teacher, <b>I want to</b> drag and position imported items within the virtual space, <b>so that</b> I can design and organise interactive learning environments</td>
      <td>There are the imported items on the default area</td>
      <td>I drag the items to other area</td>
      <td>The items are dragged to other place</td>
    </tr>
    <tr>
      <td>I drag the item to somewhere and there is a "CANCEL" button on environment edit interface</td>
      <td>I click the "CANCEL" button</td>
      <td>The dragged item will be restored to its default position</td>
    </tr>
    <tr>
      <td align="center" >US1.5</td>
      <td ><b>As a</b> teacher, <b>I want to</b> save the environment configurations I create, <b>so that</b> I can reuse and share educational setups easily </td>
      <td>I create a new environment and there is a "SAVE" button on environment edit interface</td>
      <td>I click the "SAVE" button</td>
      <td>The modified environment will be saved to the default path</td>
    </tr>
    <tr>
      <td rowspan = 8 align="center"><b>Account Management</b></td>
      <td align="center">US2.1</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> register an account using my email, <b>so that</b> I can access to the system and have my information stored securely</td>
      <td>There is a 'REGISTER' button in login interface</td>
      <td>I click the 'REGISTER' button</td>
      <td>The system change to register mode where can create the new account</td>
    </tr>
    <tr>
      <td align="center" >US2.2</td>
      <td ><b>As a</b> teacher or student, <b>I want to</b> use my password and email to login, <b>so that</b> I can access the system</td>
      <td>The login interface has two columns, one for entering email address and one for entering password. There is a 'LOGIN' button blow it</td>
      <td>I type my email and password then click 'LOGIN' button</td>
      <td>I can access the system</td>
    </tr>
    <tr>
      <td align="center" rowspan = 3 >US2.3</td>
      <td rowspan = 3 ><b>As a</b> teacher or student, <b>I want to</b> reset my password through my email, <b>so that</b> I can reset my password</td>
      <td>There will be a forgot password button in login interface</td>
      <td>I click the forgot password button</td>
      <td>There interface will jump to send reset password interface</td>
    </tr>
    <tr>
      <td>There is a column on reset password interface to fill in the email and a 'SEND" button blow it</td>
      <td>I type my email and click 'SEND' button</td>
      <td>A reset password email will be sent to my mail</td>
    </tr>
    <tr>
      <td>There is a reset password email in my mail</td>
      <td>I open the reset password email and add my new password</td>
      <td>My password will be reset</td>
    </tr>
    <tr>
      <td align="center">US2.4</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> exit the game, <b>so that</b> I can end this tour</td>
      <td>I already access the system and there is a 'QUIT' button</td>
      <td>I click the 'QUIT' button</td>
      <td>The system will exit to the login interface</td>
    </tr>
    <tr>
      <td align="center" rowspan = 2>US2.5</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> choose my role(student or teacher), <b>so that</b> I can simulate the appropriate scenery for my role</td>
      <td>There is a 'Teacher Account' button and 'Student Account' button on login interface</td>
      <td>I click the 'Teacher Account' button </td>
      <td>I will join the environment as a teacher</td>
    </tr>
    <tr>
      <td>There is a 'Teacher Account' button and 'Student Account' button on login interface</td>
      <td>I click the 'Student Account' button </td>
      <td>I will join the environment as a student</td>
    </tr>
    <tr>
      <td rowspan = 6 align="center"><b>Player Creation & Customization</b></td>
      <td align="center">US3.1</td>
      <td><b>As a</b> teacher, <b>I want to</b> create a player character, <b>so that</b> I can facilitate multi-user interactions for collaboration and engagement in the virtual learning experience</td>
      <td>There is a ADD button on choose player interface</td>
      <td>I click the ADD button</td>
      <td>The system change to create mode where can create the new player character</td>
    </tr>
    <tr>
      <td align="center">US3.2</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> define the player's speed, <b>so that</b> I can customize the player's speed to suit different scenarios</td>
      <td>There is a speed attribute on edit player interface</td>
      <td>I adjust the speed independently</td>
      <td>The character's speed will be changed corresponding</td>
    </tr>
    <tr>
      <td align="center">US3.3</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> define the player's jump height, <b>so that</b> I can customize the player's jump to move around a 3D
environment.</td>
      <td>There is a platform in front of the character</td>
      <td>I press 'w' button and click space button</td>
      <td>The character's jump to the platform</td>
    </tr>
    </tr>
    <tr>
      <td align="center">US3.4</td>
      <td> <b>As a</b> teacher or student, <b>I want to</b> define the player's size, <b>so that</b> I can customize the player's size to suit different scenarios.</td>
      <td>There is a column height in attribute</td>
      <td>I type the player's height</td>
      <td>The character's size will change accordingly</td>
    </tr>
    <tr>
      <td align="center" rowspan = 2>US3.5</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> define the player's control type (motion controls or on rails), <b>so that</b> I can decide the player's control type to suit different scenarios.</td>
      <td>There is a choice of operation mode when saving the modified character</td>
      <td>I choose motion controls</td>
      <td>The character will be controlled by user's motion</td>
    </tr>
    <tr>
      <td>There is a choice of operation mode when saving the modified character</td>
      <td>I choose rails control</td>
      <td>The character will be controlled by keyboard and mouse</td>
    </tr>
     <tr>
      <td rowspan = 6 align="center"><b>Character Operation</b></td>
      <td align="center">US4.1</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> use my external equipment to control my character moving, <b>so that</b> I can move around in a virtual environment.</td>
      <td>The character's operation mode is 'motion control' and I have the external equipment</td>
      <td>I link my external equipment to the system</td>
      <td>The character will be chontrol by the external equipment </td>
    </tr>
    <tr>
      <td align="center">US4.2</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> move my mouse to control the view, <b>so that</b> I can face on any side I want</td>
      <td>I join the main interface</td>
      <td>I drag the mouse</td>
      <td>The character's view moves with the mouse</td>
    </tr>
    <tr>
      <td align="center">US4.3</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> use my external equipment to control my character to pick up, <b>so that</b> I can pick up and collect items in the virtual environment.</td>
      <td>There is a pick-up item in the virtual environment</td>
      <td>I control the character to face the item and keep pressing the left mouse button</td>
      <td>The item will be picked up</td>
    </tr>
    <tr>
      <td align="center">US4.4</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> use my external equipment to control my character to drop off items, <b>so that</b> I can put items in the virtual environment.</td>
      <td>I have picked up an item </td>
      <td>I release the left mouse button</td>
      <td>The item will be drop off</td>
    </tr>
    <tr>
      <td align="center">US4.5</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> use my external equipment to control my character to trigger an event, <b>so that</b> I can trigger event in virtual environment.</td>
      <td>There is an avaliable event in the virtual environment</td>
      <td>I face the avaliable event and click the right mouse</td>
      <td>The event will be triggered</td>
    </tr>
    <tr>
    <td align="center">US4.6</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> open a setting page, <b>so that</b> I can customize the system.</td>
      <td>There is a setting button in the main page</td>
      <td>I click the setting button</td>
      <td>The system will be changed to setting interface</td>
    </tr>
     <tr>
      <td rowspan = 6 align="center"><b>Character Integration</b></td>
      <td align="center">US5.1</td>
      <td><b>As a</b> teacher, <b>I want to</b> import images from external sources into the 3D environments created, <b>so that</b> I can enhance the virtual learning experience with image elements.</td>
      <td>I have an image which i want to insert and there is a '+' button on the edit environment interface</td>
      <td>I click the '+' button and select the image which i want to insert</td>
      <td>The image will be inserted to the environment </td>
    </tr>
    </tr>
     <tr>
      <td align="center" >US5.2</td>
      <td><b>As a</b> teacher, <b>I want to</b> import videos from external sources into the 3D environments created, <b>so that</b> I can enhance the virtual learning experience with video elements.</td>
      <td>I have a video which I want to insert and there is a '+' button on the edit environment interface</td>
      <td>I click the '+' button and select the video which i want to insert</td>
      <td>The video will be inserted to the environment </td>
    </tr>
    <tr>
      <td align="center">US5.3</td>
      <td ><b>As a</b> teacher, <b>I want to</b> import text from external sources into the 3D environments created, <b>so that</b> I can enhance the virtual learning experience with text elements.</td>
      <td>I have a text which I want to insert and there is a '+' button on the edit environment interface</td>
      <td>I click the '+' button and select the text which i want to insert</td>
      <td>The text will be inserted to the environment </td>
    </tr>
    <tr>
      <td align="center">US5.4</td>
      <td><b>As a</b> teacher, <b>I want to</b> import quizzes from external sources into the 3D environments created, <b>so that</b> I can enhance the virtual learning experience with quiz elements.</td>
      <td>I have a quiz which I want to insert and there is a '+' button on the edit environment interface</td>
      <td>I click the '+' button and select the quiz which i want to insert</td>
      <td>The quiz will be inserted to the environment </td>
    </tr>
    <tr>
      <td align="center">US5.5</td>
      <td><b>As a</b> teacher, <b>I want to</b> import slides from external sources into the 3D environments created, <b>so that</b> I can enhance the virtual learning experience with slides elements.</td>
      <td>I have some slides that I want to insert and there is a '+' button on the edit environment interface</td>
      <td>I click the '+' button and select the slides which i want to insert</td>
      <td>The slides will be inserted to the environment </td>
    </tr>
     <tr>
      <td align="center">US5.6</td>
      <td><b>As a</b> teacher, <b>I want to</b> drag various media to any place I want when creating the 3D environment, <b>so that</b> I can create an environment with different media.</td>
      <td>I have some media that I want to insert into the environment and there is a '+' button on the edit environment interface</td>
      <td>I click the '+' button and select the media which i want to insert</td>
      <td>The media will be inserted to the environment </td>
    </tr>
    <tr>
      <td rowspan = 10 align="center"><b>Resources events</b></td>
      <td align="center" rowspan = 2>US6.1</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> trigger the event ‘watch’ when moving close to an image, <b>so that</b> I can watch the imported image within the virtual learning environment.</td>
      <td>I am in the environment and there is an image</td>
      <td>I click the 'WATCH' button</td>
      <td>I can watch the image </td>
    </tr>
    <tr>
      <td>I am in the environment and there is an image shown in front of me</td>
      <td>I click the 'CLOSE' button</td>
      <td>The image will be closed</td>
    </tr>
    <tr>
      <td align="center" rowspan = 2>US6.2</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> trigger the event ‘watch’ when moving close to a video, <b>so that</b> I can watch the imported video within the virtual learning environment.</td>
      <td>I am in the environment and there is a video</td>
      <td>I join the environment and move close the video, then I click the 'WATCH' button</td>
      <td>I can watch the video </td>
    </tr>
    <tr>
      <td>I am in the environment and there is a video shown in front of me</td>
      <td>I click the 'CLOSE' button</td>
      <td>The video will be closed</td>
    </tr>
    <tr>
      <td align="center" rowspan = 2>US6.3</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> trigger the event ‘read’ when moving close to a text, <b>so that</b> I can read the imported text within the virtual learning environment.</td>
      <td>I am in the environment and there is a text</td>
      <td>I join the environment and move close the text, then I click the 'READ' button</td>
      <td>I can read the text</td>
    </tr>
    <tr>
      <td>I am in the environment and there is a text shown in front of me</td>
      <td>I click the 'CLOSE' button</td>
      <td>The text will be closed</td>
    </tr>
    <tr>
      <td align="center" rowspan = 2>US6.4</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> trigger the event ‘start quiz’ when moving close to a quiz, <b>so that</b> I can start and complete the imported quiz within the virtual learning environment.</td>
      <td>I am in the environment and there is a quiz</td>
      <td>I join the environment and move close the quiz, then I click the 'START QUIZ' button</td>
      <td>I can read the quiz</td>
    </tr>
    <tr>
      <td>I am in the environment and there is a quiz shown in front of me</td>
      <td>I click the 'CLOSE' button</td>
      <td>The quiz will be closed</td>
    </tr>
    <tr>
      <td align="center" rowspan = 2>US6.5</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> trigger the event ‘watch’ when moving close to slides, <b>so that</b> I can watch the imported slides within the virtual learning environment.</td>
      <td>I am in the environment and there is a slides</td>
      <td>I join the environment and move close the slides, then I click the 'WATCH' button</td>
      <td>I can read the slides</td>
    </tr>
    <tr>
      <td>I am in the environment and there is a slides shown in front of me</td>
      <td>I click the 'CLOSE' button</td>
      <td>The slides will be closed</td>
    </tr>
    <tr>
      <td align="center" rowspan = 6><b>Resources Management</b></td>
      <td align="center" rowspan = 2>US7.1</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> open a folder to save resources, <b>so that</b> I can save all the resources and share them between users.</td>
      <td>The is a share folder on the main interface.</td>
      <td>I enter the system and click the share folder</td>
      <td>I can see many resources from other users</td>
    </tr>
     <tr>
      <td>I have some resources</td>
      <td>I save the resources into the share folder</td>
      <td>Other users can see my resources in the share folder</td>
    </tr>
     <tr>
      <td align="center" rowspan = 2>US7.2</td>
      <td rowspan = 2><b>As a</b> teacher or student, <b>I want to</b> open a backpack to save items I have uploaded or picked up, <b>so that</b> I can effectively manage and utilize my creative resource.</td>
      <td>I have saved my resources into the share folder</td>
      <td>I enter the main page and click the backpack button</td>
      <td>I can see many items that I have uploaded or picked up</td>
    </tr>
    <tr>
      <td>I have opened the backpack</td>
      <td>I click the backpack button again</td>
      <td>The backpack will be closed</td>
    </tr>
    <tr>
      <td align="center">US7.3</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> share resources in my resources library with others, <b>so that</b> I can spread my creativity.</td>
      <td>I have a resource</td>
      <td>I enter the main page and put the resources into the resources library</td>
      <td>Other people can see my resources in the resources library through searching my account name</td>
    </tr>
    <tr>
      <td align="center">US7.4</td>
      <td><b>As a</b> teacher or student, <b>I want to</b> save the object shared by others, <b>so that</b> I can learn and draw inspiration from others' resources, promote information sharing and exchange, and enhance the teaching experience.</td>
      <td>There is a share folder on the main interface and some resources in the folder.</td>
      <td>I enter the system and click the share folder, then find some resources and save them into my environment</td>
      <td>I can see the shared resources saved in my environment and I can change them.</td>
    </tr>
  </table>
