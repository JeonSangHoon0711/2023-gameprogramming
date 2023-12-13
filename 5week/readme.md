#5주차는 발표진행 , 6주차 발표 자료 모음


인트로 화면 추가입니다.
printf
scanf
switch 문을 이용하여 구성했습니다.
1번 선택시
display_phone_pad 와 control_phone_pad 함수를 실행합니다
2번 선택시
settingMenu 함수가 실행되며 설정 화면으로 이동합니다
3번 선택시
지금까지 생성한 문자 메시지를 출력하는 printinputarray() 함수를 실행합니다
4번 선택시 프로그램이 종료됩니다.

설정 화면 추가 입니다.
settingsMenu 함수로 구성하였으며
printf scanf switch 문을 이용하여 구성했습니다.
1번 선택시
setSound 함수가 실행되며 소리 설정 화면으로 넘어갑니다
2번 선택시
changeColor 함수가 실행되며 글자 색상 변경 화면으로 넘어갑니다
3번 선택시
changevackgroundcolor 함수가 실행되며 배경색상 변경 화면으로 넘어갑니다
4번 선택시 settingsMenu 함수가 종료되고 main 메뉴로 돌아갑니다.

소리 설정 입니다
setSound 함수로 구성하였으며
현재 소리 상태, 소리 on / off 가 화면에 출력됩니다.
1번 선택시 beepcheck 가 true 가 되며 비프음이 발생하게됩니다
2번 선택시 beepcheck 가 false 가 되며 비프음이 발생하지 않게 됩니다
3번 선택시 설정 화면으로 돌아갑니다.

글자 색상 설정 입니다
changecolor 함수로 구성하였으며
switch 문을 이용하여
각 번호에 맞는 색상으로 변경되게 구성하였으며
sprintf를 이용하여 색상을 저장하고
system(command)를 사용하여 색상이 변경되게 설정했습니다.
(sprintf는 printf와 비슷하지만 출력하지않고 문자열로 저장함)

배경 색상 설정입니다
changebackgroundcolor 함수로 구성하였으며
switch 문을 이용하여
각 번호에 맞는 색상으로 변경되게 구성하였으며
sprintf를 이용하여 색상을 저장하고
system(command)를 사용하여 색상이 변경되게 설정했습니다.
(sprintf는 printf와 비슷하지만 출력하지않고 문자열로 저장함)

입력 내용 저장 기능입니다.
inputarray에 출력되는 문자를 저장합니다.

입력 내용 출력 화면, 기능 입니다.
인트로 화면에서 3번 선택지를 통해
printinputarray 함수가 실행되며
inputarray 배열 내용을 출력합니다.

글자 삭제 기능입니다.
공백 문자를 입력했을때
\b (백스페이스)를 두번 출력하여
커서를 한칸옮긴 후 해당위치를 공백으로 덮어 씌우며
삭제 기능을 구연했습니다.

엔터 기능 입니다
e 키를 누를경우
개행문자를 출력하고 숫자키입력을 다시 출력하고
inputarray 에 개행문자를 넣습니다.

메인화면으로 나가는 기능입니다
q를 나가면 인트로 화면으로 나갑니다.

종료기능 입니다
인트로 화면에서 4번 선택시 프로그램이 종료됩니다

<img src = "https://github.com/JeonSangHoon0711/2023-gameprogramming/blob/main/5week/image.png?raw=true">
