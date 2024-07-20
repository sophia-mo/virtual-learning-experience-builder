 <table>
    <tr align="center">
      <th rowspan = 2>Epic</th>
      <th rowspan = 2>ID</th>
      <th rowspan = 2>Acceptance Criteria</th>
      <th rowspan = 2>Test ID</th>
      <th rowspan = 2>Acceptance Test</th>
      <th colspan = 2>Critical</th>
      <th colspan = 2>Test Result</th>
      <th rowspan = 2>Comment</th>
    </tr>
   <tr align="center">
      <th>Yes</th>
      <th>No</th>
      <th>Accept</th>
      <th>Reject</th>
    </tr>
    <tr align="center">
      <th colspan = 10></th>
   </tr>
    <tr>
      <td rowspan = 9 align="center"><b>Environmental Creation</b></td>
      <td align="center" rowspan = 3>US 1.1</td>
      <td rowspan = 2><b>Given</b> there is an 'ADD' button on environment select interface, <b>When</b> I click the 'ADD' button, <b>Then</b> the system change to edit mode which can create new environment</td>
      <td>AT01</td>
      <td>User in the environment select interface and click 'ADD' button. After this, system will be changed to eidt mode</td>
      <td></td>
      <td></td>
      <td></td>
      <td></td>
      <td></td>
    </tr>
    
  <tr>
      <td>AT02</td>
      <td>User clicks the ‘+’ among the environment and then the user should be directed to the ‘Select Player Mode’ page. The environment should be created after the user chooses the player.</td>
      <td></td>
      <td></td>
      <td></td>
      <td></td>
      <td></td>
    </tr>

  <tr>
    <td>Given there is a 'EDIT' button on environment select interface, when I click the 'EDIT' button,  then the system change to edit mode which can the existing environment.</td>
    <td>AT03</td>
    <td>Users sees the environments listed on the screen and select the environment that they want to edit and press the ‘edit’ button below. </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 1.2</td>
    <td rowspan = 2>Given there is a 'resource' button on environment edit interface, when I click the 'resource' button, then the resource folder will be opened and there are many items in different categories</td>
    <td>AT04</td>
    <td>User chose to be a teacher and selected his/her player in their environment.  </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>AT05</td>
    <td>The user clicks the 'resource' button on the left, and  a folder will expand on the left side, containing various input objects.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 1.3</td>
    <td>Given I scanned an item and there is a 'IMPORT' button on the environment edit interface, when I click the 'IMPORT' button and import 3D scanned items, then the selected items will be imported to the environment.</td>
    <td>AT06</td>
    <td>User locates and clicks the 'IMPORT' button visible on the environment edit interface, then the user selects the 3D scanned items they wish to import into the virtual environment. User should be able to see and interact with the imported items within the virtual environment.  </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 1.4</td>
    <td>Given there are the imported items in the default area, when I drag the items to another area, then the items are dragged to another place.</td>
    <td>AT07</td>
    <td>User drags the selected item from the default area to a different designated area within the environment. Once the drag operation is completed, the item should remain in the new location, verifying that it has been successfully moved.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan >Given I drag the item to somewhere and there is a "CANCEL" button on the environment edit interface, when I click the "CANCEL" button, then the dragged item will be restored to its default position.</td>
    <td>AT08</td>
    <td>The user tries to move the object, he/she identifies and clicks the "CANCEL" button located on the environment edit interface then the system automatically move the item back to its original or default position</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan>US 1.5</td>
    <td>Given I create a new environment and there is a "SAVE" button on environment edit interface, when I click the "SAVE" button, then the modified environment will be saved to the default path.</td>
    <td>AT09</td>
    <td>After completing the modifications, the user locates and clicks the "SAVE" button on the environment edit interface. The system should confirm that the environment has been saved successfully, ideally through a notification or status message.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 10 align="center"><b>Account Management</b></td>
    <td rowspan = 2>US 2.1</td>
    <td rowspan = 2>Given there is a 'REGISTER' button in login interface, when I click the 'REGISTER' button then the system change to register mode where can create the new account</td>
    <td>AT10</td>
    <td>After completing the modifications, the user locates and clicks the "SAVE" button on the environment edit interface. The system should confirm that the environment has been saved successfully, ideally through a notification or status message.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>AT11</td>
    <td>Users input their information(username, password and email) in the ‘Register’ page and click ‘register’. The account will be created and lead users to the ‘Login’ page to login. </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan>US 2.2</td>
    <td>Given I have an account about this system and there is a 'LOGIN' button in login interface, when I type my account information and click the 'LOGIN' button, then the system will pop up a login interface for account login</td>
    <td>AT12</td>
    <td>User input information(email address and password) in the ‘Login’ page and click the ‘LOGIN’ button, the system redirects the user to the ‘Home’ screen.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 4>US 2.3</td>
    <td>Given there will be a forgot password button in the login interface, when I click the forgot password button, then there will be a reset password interface.</td>
    <td>AT13</td>
    <td>User locates the 'Forgot Password' button on the login interface and clicks the 'Forgot Password' button then the system should transition from the login interface to a reset password interface.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given there is a column on the reset password interface to fill in the email and a "SEND" button below it, when I type my email and click the 'SEND' button then A reset password email will be sent to my mail.</td>
    <td>AT14</td>
    <td>User enters a valid email address in the designated column on the reset password interface and clicks the 'SEND' button located below the email input.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan=2>Given there is a reset password email in my mail, when I open the reset password email and add my new password, then my password will be reset.</td>
    <td>AT15</td>
    <td>User opens the reset password email and follows the link or instructions provided in the email to navigate to the password reset page.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>AT16</td>
    <td>User enters a new password and confirms it as required by the password reset page. The system accepts the new password and updates the user’s account with this new password. Then the user should be able to log in with the new password.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan>US 2.4</td>
    <td>Given I already access the system and there is a 'QUIT' button, when I click the 'QUIT' button, then the system will exit to the login interface.</td>
    <td>AT17</td>
    <td>User locates and clicks the 'QUIT' button, typically found on the main interface or within a menu. The system redirects the user to the login interface, indicating a successful logout and system exit.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 2.5</td>
    <td>Given there is a 'Teacher Account' button and 'Student Account' button on the login interface, when I click the 'Teacher Account' button, then I will join the environment as a teacher.</td>
    <td>AT18</td>
    <td>User locates and clicks the 'Teacher Account' button on the login interface, the system authenticates and logs the user in as a teacher.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given there is a 'Student Account' button and 'Student Account' button on the login interface, when I click the 'Student Account' button, then I will join the environment as a teacher.</td>
    <td>AT19</td>
    <td>User locates and clicks the 'Student Account' button on the login interface, the system authenticates and logs the user in as a student.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 7 align="center"><b>Player Creation & Customization</b></td>
    <td rowspan = 2>US 3.1</td>
    <td rowspan = 2>Given there is an ADD button on the player interface, when I click the ADD button, then the system changes to create mode where I can create the new player character.</td>
    <td>AT20</td>
    <td>User in ‘Select Player Model’ is able to see a ‘+’ in the Screen, user clicks the '+’ button and the system will direct to a page that used for defining a player. </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>AT21</td>
    <td>Once the user has adjusted the player(Jump, Height and Speed), he/she clicks ‘menu’ which is a drop down menu on the top left, then select ‘Save’ in that ‘menu’.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 3.2</td>
    <td rowspan = 2>Given there is a speed attribute on the edit player interface, when I adjust the speed independently, then the character's speed will be changed correspondingly.</td>
    <td>AT22</td>
    <td>User locates the speed input field for the selected player character within the edit player interface and adjusts the speed setting by entering a new value in the input field. </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>AT23</td>
    <td>User clicks the ‘menu’ on the top left and locates ‘Save’. After clicking ‘Save’, the speed of the selected player has been edited(if only editing the speed).</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan>US 3.3</td>
    <td rowspan>Given there is a platform in front of the character, when I press the 'w' button and click the space button then the character's jump to the platform.</td>
    <td>AT24</td>
    <td>User presses the 'W' button to move the character forward. Simultaneously or subsequently, the user presses the space button to initiate the jump. Then the user is on the platform.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 3.4</td>
    <td rowspan = 2>Given there is a column height in the attribute, when I type the player's height, then the character's size will change accordingly.</td>
    <td>AT25</td>
    <td>User locates the height input field for the selected player character within the edit player interface and adjusts the height setting by entering a new value in the input field.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>AT26</td>
    <td>User clicks the ‘menu’ on the top left and locates ‘Save’. After clicking ‘Save’, the height of the selected player has been edited(if only editing the height).</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 6 align="center"><b>Character Operation</b></td>
    <td rowspan>US 4.2</td>
    <td rowspan >Given I join the main interface, when I drag the mouse, then the character's view moves with the mouse.</td>
    <td>AT27</td>
    <td>User positions the mouse cursor within the game interface and drags the mouse in various directions to test the responsiveness of the view control. The character’s viewpoint immediately and smoothly adjust to match the direction and extent of the mouse movement. </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan>US 4.3</td>
    <td rowspan>Given there is a pick-up item in the virtual environment, when I control the character to face the item and keep pressing the left mouse button, then the item will be picked up.</td>
    <td>AT28</td>
    <td>User clicks and holds the left mouse button to pick up an item within the virtual environment.The items will always be on the right hand side of the screen until the user releases the left mouse button.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan>US 4.4</td>
    <td rowspan>Given I have picked up an item, when I release the left mouse button, then the item will drop off.</td>
    <td>AT29</td>
    <td>User releases the left mouse button to attempt to drop the item. Then the item should be released and visually appear to drop off at the location where the mouse was last positioned.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 4.5</td>
    <td rowspan = 2>Given there is an available event in the virtual environment, when I face the available event and click the right mouse, then the event will be triggered.</td>
    <td>AT30</td>
    <td>The user presses ‘w’ to move to the event and face the event.The user will notice there is the interactive button shown below the event.
    </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>AT31</td>
    <td>The user locates the interactive button and clicks the right mouse button. The event will be enlarged and shown on the user’s screen.
    </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 4.6</td>
    <td>Given there is a setting button in the main page, when I click the setting button, then the system will be changed to the setting interface.</td>
    <td>AT32</td>
    <td>User locates the settings button on the main page and clicks on the settings button. The system should transition from the main page to the settings interface.
    </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

<tr>
    <td rowspan = 6 align="center"><b>Character Integration</b></td>
    <td rowspan>US 5.1</td>
    <td rowspan >Given I have an image which i want to insert and there is a '+' button on the edit environment interface, when I click the '+' button and select the image which i want to insert, then the image will be inserted to the environment.</td>
    <td>AT33</td>
    <td>User click the '+' button and select the image they want to insert,  the image will be inserted to the environment.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 5.2</td>
    <td>Given I have an video which i want to insert and there is a '+' button on the edit environment interface, when I click the '+' button and select the video which i want to insert, then the video will be inserted to the environment.</td>
    <td>AT34</td>
    <td>User click the '+' button and select the video they want to insert,  the video will be inserted to the environment.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 5.3</td>
    <td>Given I have an text which i want to insert and there is a '+' button on the edit environment interface, when I click the '+' button and select the text which i want to insert, then the text will be inserted to the environment.</td>
    <td>AT35</td>
    <td>User click the '+' button and select the text they want to insert,  the text will be inserted to the environment.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 5.4</td>
    <td>Given I have an quiz which i want to insert and there is a '+' button on the edit environment interface, when I click the '+' button and select the quiz which i want to insert, then the quiz will be inserted to the environment.</td>
    <td>AT36</td>
    <td>User click the '+' button and select the quiz they want to insert,  the quiz will be inserted to the environment.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 5.5</td>
    <td>Given I have an slides which i want to insert and there is a '+' button on the edit environment interface, when I click the '+' button and select the slides which i want to insert, then the slides will be inserted to the environment.</td>
    <td>AT37</td>
    <td>User click the '+' button and select the slides they want to insert,  the slides will be inserted to the environment.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 5.6</td>
    <td>Given I have an media which i want to insert and there is a '+' button on the edit environment interface, when I click the '+' button and select the media which i want to insert, then the media will be inserted to the environment.</td>
    <td>AT38</td>
    <td>User click the '+' button and select the media they want to insert,  the media will be inserted to the environment.</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 10 align="center"><b>Resources Events</b></td>
    <td rowspan = 2>US 6.1</td>
    <td>Given i am in the environment and there is an image, when I click the 'WATCH' button, then I can watch the image</td>
    <td>AT39</td>
    <td>User in the environment move close to the image and click the 'WATCH' button, the image can be shown to the user</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given i am in the environment and there is an image shown in front of me, when I click the 'CLOSE' button, then the image will be closed</td>
    <td>AT40</td>
    <td>User click the 'CLOSE' button below the image when it opened, the image will be closed</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 6.2</td>
    <td>Given I am in the environment and there is a video, when I click the 'WATCH' button, then I can watch the video</td>
    <td>AT41</td>
    <td>User in the environment move close to the video and click the 'WATCH' button, the video can be shown to the user</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given I am in the environment and there is a video shown in front of me, when I click the 'CLOSE' button, then the video will be closed</td>
    <td>AT42</td>
    <td>User click the 'CLOSE' button below the video when it opened, the video will be closed</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 6.3</td>
    <td>Given I am in the environment and there is a text, when I click the 'WATCH' button, then I can watch the text</td>
    <td>AT43</td>
    <td>User in the environment move close to the text and click the 'WATCH' button, the text can be shown to the user</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given I am in the environment and there is a text shown in front of me, when I click the 'CLOSE' button, then the text will be closed</td>
    <td>AT44</td>
    <td>User click the 'CLOSE' button below the text when it opened, the text will be closed</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 6.4</td>
    <td>Given I am in the environment and there is a quiz, when I click the 'WATCH' button, then I can watch the quiz</td>
    <td>AT45</td>
    <td>User in the environment move close to the quiz and click the 'WATCH' button, the quiz can be shown to the user</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given I am in the environment and there is a quiz shown in front of me, when I click the 'CLOSE' button, then the quiz will be closed</td>
    <td>AT46</td>
    <td>User click the 'CLOSE' button below the quiz when it opened, the quiz will be closed</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 6.5</td>
    <td>Given I am in the environment and there is a slides, when I click the 'WATCH' button, then I can watch the slides</td>
    <td>AT47</td>
    <td>User in the environment move close to the slides and click the 'WATCH' button, the slides can be shown to the user</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given I am in the environment and there is a slides shown in front of me, when I click the 'CLOSE' button, then the slides will be closed</td>
    <td>AT48</td>
    <td>User click the 'CLOSE' button below the slides when it opened, the slides will be closed</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 6 align="center"><b>Resources Management</b></td>
    <td rowspan = 2>US 7.1</td>
    <td>Given there is a share folder on the main interface, when I enter the system and click the share folder, then I can see many resources from other users</td>
    <td>AT49</td>
    <td>User click the share folder, then resources from other users are shown</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given I have some resources, when I save the resources into the share folder, then other users can see my resources in the share folder</td>
    <td>AT50</td>
    <td>User enter the system and save the resources into the share folder, then other users can see the resources in the share folder</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td rowspan = 2>US 7.2</td>
    <td>Given I have saved my resources into the share folder, when I enter the main page and click the backpack button, then I can see many items that I have uploaded or picked up</td>
    <td>AT51</td>
    <td>User enter the main page and click the backpack button, then items that they uploaded or picked up are shown</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>Given I have opened the backpack, when click the backpack button again, then The backpack will be closed</td>
    <td>AT52</td>
    <td>User click the backpack button again, then the backpack will be closed</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

  <tr>
    <td>US 7.3</td>
    <td>Given I have a resource, when I enter the main page and put the resources into the resources library, then other people can see my resources in the resources library through searching my account name</td>
    <td>AT53</td>
    <td>User enter the main page and put the resources into the resources library, then search their account name, their resources are shown</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>
  
  <tr>
    <td>US 7.4</td>
    <td>Given there is a share folder on the main interface and some resources in the folder, when I enter the system and click the share folder, then find some resources and save them into my environment, then I can see the shared resources saved in my environment and I can change them.</td>
    <td>AT54</td>
    <td>User enter the system, click the share folder, find a resource and save it into their own environment, then the shared resources are shown in the environment</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>

 </table>

