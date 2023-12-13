#w3school html game 하나 정해서 발표준비 + 다음주 발표 자료  
https://jeonsanghoon0711.github.io/2023-gameprogramming/9week/2019775054.html  
https://jeonsanghoon0711.github.io/2023-gameprogramming/9week/2019775054_ms.html

코드분석에 myGameArea 부분입니다
여기서는 게임 영역을 생성하는 작업을 진행합니다
canvas 를 이용하여 캔버스를 생성후
start 로 게임을 실행하는 작업을 합니다
여기서 this.context 부분을 사용하여 캔버스에 그림을 그리는 용으로 사용을 했고
body.insertbefore 를 사용하여 html body 의 맨앞에 삽입 했습니다.
인터벌을 사용하여 20밀리초마다 updateGameArea 함수를 호출합니다 이 인터벌 값이 게임의 속도 느낌으로 사용됩니다
키보드 이벤트에 대한 리스너를 추가합니다


component 입니다
여기서는 게임에 사용되는 빨간 사각형을 생성하는 작업을 진행합니다
변수들을 선언후
update 메서드와
newPos 메서드를 생성합니다
아래는 컴포넌트에서 만들어진 객체를 할당하는 코드입니다 

updategamearea 입니다
함수는 게임 화면을 지우고, 사용자의 입력에 따라 게임 요소의 이동 방향과 속도를 설정하고, 게임 요소의 위치를 업데이트하고, 게임 요소를 화면에 다시 그리는 역할을 합니다. 이 함수는 주기적으로 호출되어 게임 화면을 지속적으로 업데이트하게 됩니다.

전체 동작을 보면
웹 페이지가 로드될 때, body 태그의 onload 속성에 의해 startGame 함수가 호출됩니다.
startGame 함수가 호출되면, 이 함수는 myGamePiece라는 새로운 게임 요소(빨간 사각형)를 생성하고, myGameArea의 start 메서드를 호출하여 게임을 시작합니다.
myGameArea.start 메서드에서는 캔버스를 생성하고, 그림을 그리기 위한 2D 컨텍스트를 가져옵니다. 캔버스는 문서에 추가되고, setInterval 함수를 통해 20ms마다 updateGameArea 함수가 호출되도록 설정됩니다. 이는 게임 상태를 지속적으로 업데이트하고 화면을 갱신하는 데 사용됩니다.
또한, 키보드의 keydown과 keyup 이벤트에 대한 이벤트 리스너를 추가합니다. 이 이벤트 리스너들은 사용자가 키를 누르거나 뗄 때마다 호출되어, myGameArea.keys 배열을 업데이트합니다. 이 배열은 각 키의 상태(눌림 또는 떼짐)를 저장합니다.
updateGameArea 함수는 myGameArea를 지우고, myGamePiece의 moveAngle과 speed를 업데이트하며, myGamePiece의 위치를 갱신하고 화면에 그립니다. 이 함수는 myGameArea.keys 배열의 상태를 확인하여, 사용자가 누른 키에 따라 myGamePiece의 방향과 속도를 변경합니다. 

![image](https://github.com/JeonSangHoon0711/2023-gameprogramming/assets/121441565/fe6331fd-d2ed-407e-948c-8643eac86cf9)
