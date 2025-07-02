<h1>Shrek’s Swamp Maze</h1>
<p>Passing the labyrinth (maze) with enemy creatures.</p>
<ul>
  <li>Windows</li>
  <li>Landscape orientation</li>
</ul>

<h2>Concept:</h2>
<p>The project is a labyrinth-walker in the style of the animated film "Shrek". </p>

<p>The main character, an ogre, urgently needs to get to a place of extreme solitude, but he discovers that his native and quiet swamp has been captured by some strange tree-like creatures.</p>

<p>Controlling the main character, you need to get to the desired place, driving away uninvited guests and politely asking (by shouting loudly) them to leave the private territory. But you need to be careful, as they look very unfriendly to constructive dialogue.</p>

<p>Upon reaching the finish line, Shrek passes the maze level and wins, and upon receiving damage (weighty arguments against Shrek's claims) from an uninvited guest, he loses health and loses.</p>

<p>In order to be more convincing when explaining that this is private territory, it is necessary to collect signs saying "Caution! Evil Ogre!" The more signs collected, the better.</p>

<h2>Reference and visual style:</h2>
<p>The reference is our own project on a similar topic, implemented in the visual programming environment Scratch:</p>
<href>https://scratch.mit.edu/projects/933567218</href>

<p></p>
<figure>
   <img src="./Pictures/Pic_1.png" width="800"/>
   <figcaption>Picture 1 - UI of the original Scratch project</figcaption>
  </figure>

<p></p>

<p></p>
<figure>
   <img src="./Pictures/Pic_2.png" width="800"/>
   <figcaption>Picture 2 - Scratch project level design</figcaption>
  </figure>

<p></p>
 



<p>However, the current implementation of the project involves 3D visualization:</p>
<ul>
  <li>3D models of the player, enemies, start and finish, bonuses, and the maze level.</li>
  <li>The camera is static and looks down at the level from above at an angle.</li>
  <li>In order for all locations of enemies and bonuses to be visible, the boundary walls of the labyrinth will be visually lower than the height of the hero and enemies.</li> 
</ul>

<p></p>
<figure>
   <img src="./Pictures/Pic_3.png" width="800"/>
   <figcaption>Picture 3 - Example of camera placement</figcaption>
  </figure>

<p></p>
  
<p>UI относительно минималистичный, по аналогии с оригиналом, но с наличием кнопок.</p>
<p>Визуальный стиль уровней соответствует стилистике мультипликационного мультфильма: природный ландшафт, узнаваемая модель игрока и соответствующие по стилистике модели врагов, старта и финиша. Стены лабиринта визуально представляют из себя растительность (кусты).</p>

<p></p>
<figure>
   <img src="./Pictures/Pic_4.png" width="800"/>
   <figcaption>Рисунок 4 - 3D модели игрока, старта и финиша, врагов и бонусов</figcaption>
  </figure>

<p></p>

<h2>Жизненный цикл:</h2>
<ol>
  <li>Запуск/начало игры по нажатию на кнопку «START» в стартовом меню.</li>
  <li>Экран с сюжетом/предысторией, описанием управления и кнопкой с переходом к уровню с лабиринтом.</li>
  <li>Прохождение лабиринта от точки «СТАРТ» до точки «ФИНИШ», избегание вражеских существ, «пугание» вражеских существ, сбор бонусов в виде табличек.
</li>
  <li>Игрок проигрывает (кончаются жизни) при прикосновении к вражескому существу, включается экран с проигрышем и предложением начать игру заново, нажав на кнопку «RESTART». Происходит переход на пункт 1.
</li>
  <li>Игрок выигрывает при успешном достижении точки «ФИНИШ». Включается экран «Ты выиграл», на котором показываются заработанные очки, а также предлагается еще раз пройти игру заново по нажатию на кнопку «RESTART». Происходит переход на пункт 1.
</li>
</ol>

<h2>Механики и фичи:</h2>
<h3><u>Core-механики:</u></h3>
<ul>
  <li>Игрок управляется нажатием на клавиши W, A, S, D.</li>
  <li>Игрок «пугает» при нажатии на клавишу Q.
</li>
  <li>Игрок перемещается по лабиринту, не проходя сквозь его стены и вражеских существ.
</li>
  <li>Игрок проигрывает (теряет жизни) при прикосновении к вражескому существу.
</li>
  <li>При приближении игрока статический враг поворачивается в сторону игрока и пытается его атаковать.
</li>
  <li>Статический враг погибает при попадании в него «крика».
</li>
  <li>Динамический враг патрулирует часть коридоров лабиринта по заданному маршруту.
</li>
  <li>Динамический враг погибает при попадании в него «крика».
</li>
  <li>При нажатии на клавишу Q из игрока вылетает «крик», который при попадании во вражеское существо отнимает у него жизни.
</li>
    </ul>

<h3><u>Additional-механики:</u></h3>
<ul>
  <li>Игрок собирает бонусы в виде табличек и получает за это очки.
</li>
  <li>При достижении финиша игрок переносится на следующий уровень.

  <li><ul>
    <li>1 уровень – все враги статичны и чтобы пройти уровень их необходимо «напугать».
</li>
    <li>2 уровень (стелс) – все враги динамичные и перемещаются по лабиринту, но атаковать их нельзя, а можно только-лишь избегать их в других частях лабиринта.
</li>
    <li>3 уровень – враги статичные и динамичные, которых можно «пугать».
</li>
 </ul>   

  <li>Динамичный враг перемещается не по заданному пути, а между определенными точками в случайном порядке, самостоятельно выбирая кратчайший путь.
</li>
  <li>При нахождении игрока на близком расстоянии динамический враг начинает его преследовать, отклоняясь от своего маршрута.
</li>
  <li>При нахождении игрока на очень близком расстоянии от динамического врага враг начинает его атаковать.
</li>
  <li>Начисление очков за «испуг» вражеского существа.
</li>
    </ul>

<h3><u>Juice-механики:</u></h3>
<ul>
  <li>Игрок не может завершить уровень до тех пор, пока не соберет все бонусы и/или не «испугает» всех вражеских существ.
</li>
  <li>Перемещение/толкание предметов в лабиринте подобно игре «Sokoban».
</li>
  <li>Добавление предметов, которые можно перемещать по лабиринту.
</li>
  <li>Добавление нового уровня, в котором присутствует механика перемещения предметов.
</li>
</ul>

<h2>Билд:</h2>
<p>Билд проекта можно скачать по следующей ссылке:</p>
<href>https://drive.google.com/drive/folders/1vqVZ-kQntSPhnt7hrg3ffa7bEabEGP9F?usp=sharing</href>
<h2>Инструкция по запуску:</h2>
<p>1. Скачать билд проекта по ссылке.</p>
<p>2. Разархивировать скачанные файлы, если они скачались архивом.</p>
<p>3. Запустить ShrekMaze3D.exe.</p>
