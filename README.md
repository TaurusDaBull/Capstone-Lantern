<h1>Lantern <img src="https://www.gcu.edu/sites/default/files/media/Documents/brand/logos/png/GCU_267.png" width="100" height="100"> Senior Capstone </h1>
<img src="https://github.com/TaurusDaBull/Capstone-Lantern-/assets/122051465/fcde23fc-247a-4710-a7d1-1c59082d454e" width="500" height="500">
<br>
<h1>Introduction</h1>
<p>
  Lantern is a 3D Unity puzzle game that's main mechanic is to use the provided lantern <br>
  to shine light on color coded panels and the code that is located on these panels will <br>
  only appear if the right color is present from the lantern.
</p>
<br>
<h1>Functional Requirments</h1>
<details>
  <summary>Gameplay Requirements</summary>
  <ul>As a User I would like to press the 'W' key to move forward</ul>
  <ul>As a User I would like to press the 'A' key to move left</ul>
  <ul>As a User I would like to press the 'S' key to move back</ul>
  <ul>As a User I would like to press the 'D' key to move right</ul>
  <ul>As a User I would like to press the 'E' key to throw the Lantern</ul>
  <ul>As a User I would like to use the 'Scroll Wheel' to change the color of the Lantern</ul>
  <ul>As a User I would like to press the 'Right Mouse Button' key to move forward</ul>
  <ul>As a User I would like the light from the Lantern to follow the center of the camera</ul>
</details>
<details>
  <summary>Mechanics Requirements</summary>
  <ul>As a User I would like the keypad to pop up so that I can enter the code to open the door</ul>
  <ul>As a User I would like a sound to play when a key on the keypad is pressed so that I can get an auditorial confirmation that the key is pressed</ul>
  <ul>As a User I would like the correct code to turn green so that I can get a visual confirmation that the code is correct</ul>
  <ul>As a User I would like the correct code to turn red so that I can get a visual confirmation that the code is incorrect</ul>
  <ul>As a User I would like to press a button to return the Lantern to a starting position so that I can retrive the Lantern if I should lose track of it</ul>
  <ul>As a User I would like a trajectory arc to appear when I am ready to throw the Lantern so that I can be more precise when throwing the Lantern</ul>
</details>
<details>
  <summary>Non-Functional Requirements</summary>
  <ul>As a Developer I would like to have the game be able to maintain a frame rate per second of 30 so that the experience can feel smooth throughout the entirety of the experience.</ul>
</details>
<br>
<h1>Out of Scope Features</h1>
<p>There are only two Out of Scope Features. These features were removed becasue of the extra feilds of study that would have to have been explored in order to make the features susatinable and functioning properly without creating legal issues and financial issues</p>
<details>
  <summary>Publish game to Steam Store</summary>
  <ul>Publishing the game to the Steam Store would make the game susceptible to legal action if the game violates any copyright laws.</ul>
</details>
<details>
  <summary>Create a Multiplayer feature</summary>
  <ul>Creating a multiplayer feature would require the game to be hosted on a server. Hosting appliactions on servers would inccure a cost that might not break even with the game being sold.</ul>
</details>
<br>
<h2>Hardware and Software</h2>
<h3>Unity</h3>
<p>The main game engine that was used to create Lantern</p>
<h3>Blender</h3>
<p>An enthusiast friendly sculpting software used to create the Lantern model</p>
<h3>Wwise</h3>
<p>An industry and indie standard audio pipeline software used to manage and mix sound effects and music.</p>
<h3>Quixel Mixer</h3>
<p>An Unreal product that allowed for easy texture creation and exportation into the Unity game engine.</p>
<h3>Windows 10  Version 22H2</h3>
<p>The most compatible operating system to properly run the Unity software engine</p>
<h3>Intel Core i5 10TH Gen</h3>
<p>Processor released in Q2 2020 sets baseline for performance. Any newer processor will yield better results</p>

<br>
<h1>Learned Technologies</h1>
<h3>Unity</h3>
<p>Unity is the main game engine that is used to create Lantern. This engine was chosen because of the numerous resources that were available to include: Unity forums, Youtube videos, and the most useful, the Unity asset store.</p>
<h3>Blender</h3>
<p>Blender, next to Autodesk Maya, is a 3D sculpting software that many avid hobbyists and enthusiasts use for many of their personal and professional projects. Although Blender is not a common industry standard software that is used, the Blender community is helpful when creating user and beginner friendly tools and instructions to allow for a smooth creation pipeline.</p>
<h3>Wwise</h3>
<p>Wwise is a commonly used and critically acclaimed software that allows for audio mixing and managing sound pipelines. Wwise was the second choice originally from FMOD studios. Wwise has a larger community and is seen as one of the better industry standard software as, with the other software listed, has a large, helpful community and even provided both tutorials and certifications for the software.</p>
<h3>Quixel Mixer</h3>
<p>Quixel Mixer is an Unreal product that allows for the creation of materials that can be applied to Unity assets. This software was chosen because it is the most user friendly software. Quixel Mixer was quick and easy to use when exporting material maps to Unity to apply to game objects.</p>
<h1>Demo Levels Layout</h1>
[Lantern Levels Layout]<img src="https://github.com/TaurusDaBull/Capstone-Lantern/assets/122051465/f6335452-05d3-43a7-849f-cbac96f68600">

<h1>Logical Solution</h1>
[Start-of Flowchart]<img src="https://github.com/TaurusDaBull/Capstone-Lantern/assets/122051465/35fcc58d-4b54-409a-828e-5e3284846059">

<h1>Physical Solution</h1>
[Lantern Physical Design]<img src="https://github.com/TaurusDaBull/Capstone-Lantern/assets/122051465/12270f4b-6b34-4410-947a-f5f0417bce82">

<h1>Technical Approach</h1>
<h3>Gameplay Flow</h3>
<p>To keep inline with the main objective of Lantern which is to be simple, easy, and fun I designed the game to have a simple game flow that did not require too many steps but was also still fun.</p>
<h3>Keypad Pseudo Code</h3>
<p>The goal of the game is to find the code around the set world and uase that code to open the than procced to the next level. This simple concept was easily acheived however, I wanted each playthrough to be unique so, each level has a random code</p>
<h3>Shader Code</h3>
<p>Unity has a very intresting subset of coding languages, one of them being Shader Code. With the help of Shader Code, this allowed for the main aspect of the game to become a reality as this bit of code is what allows for certain game objects to</p>
<br>
<br>
<h2>This link will take you to the <a href="https://taurusdabull.github.io/Lantern-Download/">Project Website</a> for Lantern</h2>
