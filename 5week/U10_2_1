#include <stdio.h>
#include <conio.h>
#include <time.h>
#include <windows.h>
#include <stdbool.h>

void display_phone_pad(void);
void control_phone_pad(void);
void draw_check02(int c, int r);
void gotoxy(int x, int y);
void settingsMenu(void);
void changeColor(void);
void changeBackgroundColor(void);
void setSound(void);
void printInputArray(void);
char alpha[][3]={{' '}, {'.', 'q', 'z'}, {'a', 'b', 'c'}, 
                    {'d', 'e', 'f'}, {'g', 'h', 'i'}, {'j','k','l'},
		    {'m', 'n', 'o'}, {'p', 'r', 's'}, {'t', 'u', 'v'}, 
                    {'w', 'x', 'y'}};

char colorSelection = 'F'; // 기본값은 흰색
char bgColorSelection = '0';
bool beepcheck  = false;
char inputarray[999];
int inputIndex = 0;


int main(void)
{
    int menuSelection = 0;

    while(1) {
        // 메뉴 출력 
        system("cls");
        printf("1. 프로그램 실행\n");
        printf("2. 설정\n");
        printf("3. history\n");
        printf("4. 종료\n");
        printf("선택: ");

        scanf("%d", &menuSelection);
        
        switch(menuSelection) {
            case 1:
                // 프로그램 실행 코드
                system("cls");
                display_phone_pad();
                control_phone_pad();
                break;
			case 2:		
	     		system("cls");	     	
	     		settingsMenu(); 
	     		break;
	     	case 3:
	     		printInputArray();
				break; 
            case 4:
				return 0;
	    default:
	        printf("\n잘못된 선택입니다.\n\n");
	        break;
	    }
     }
}

void settingsMenu() {
    int settingsSelection = 0;

    while(1) {
    	system("cls");
        printf("1. 소리 설정 \n");
        printf("2. 글자색상 변경\n");
        printf("3. 배경색상 변경 \n");
        printf("4. 이전 메뉴로 돌아가기\n");
        printf("선택: ");

        scanf("%d", &settingsSelection);

        switch(settingsSelection) {
            case 1: 
                setSound();
                break;
            case 2:
                changeColor();
                break;
            case 3:
                changeBackgroundColor();
                break;
            case 4:
		// 이전 메뉴로 돌아가기 
		return;
	    default:
	        printf("잘못된 선택입니다.");
	        break;
	    }
     }
}

void setSound() {
    int soundSelection;

    while(1) {
        system("cls");
        printf("현재 소리 설정: %s\n", beepcheck ? "On" : "Off");
        printf("1. 소리 On\n");
        printf("2. 소리 Off\n");
        printf("3. 이전 메뉴로 돌아가기\n");
        printf("선택: ");

        scanf("%d", &soundSelection);

        switch(soundSelection) {
            case 1:
                beepcheck = true;
                break;
            case 2:
                beepcheck = false;
                break;
            case 3:
                return; // 이전 메뉴로 돌아갑니다.
            default:
                printf("잘못된 선택입니다.\n");
                break;
         }
     }
}

void changeColor() { //글자색상변경 
    int colorChoice = 0;
    
	system("cls");
    printf("글자 색을 선택하세요 :\n1. 빨강 \n2. 초록 \n3. 노랑 \n4. 하양 \n선택 : ");
    scanf("%d", &colorChoice);
    
    switch(colorChoice) {
        case 1:
            colorSelection = 'C'; // 빨강 
            break;
        case 2:
            colorSelection = 'A'; // 초록 
            break; 
        case 3:
            colorSelection = 'E'; // 노랑  
            break;
        case 4:
	        colorSelection = 'F'; // 흰색  
	        break;	
	    default:
	        printf("Invalid choice.");
	    break;
    }

    char command[13];
	sprintf(command, "color %c%c", bgColorSelection, colorSelection);
	system(command);
}


void changeBackgroundColor() { //배경색상변경 
    int bgChoice = 0;
    
	system("cls");
	printf("배경 색을 선택하세요 : \n"
		"1. 검정\n"
		"2. 파랑\n"
		"3. 초록\n"
		"4: 청록\n"
		"5: 빨강\n"
		"6: 자주\n"
 	   "7: 갈색\n"
 	   "8: 회색\n선택:");
	scanf("%d", &bgChoice);

	switch (bgChoice) {
	case 1: bgColorSelection = '0'; break; // 검정 배경
	case 2: bgColorSelection = '1'; break; // 파랑 배경
	case 3: bgColorSelection = '2'; break; // 초록 배경
	case 4: bgColorSelection = '3'; break; // 청록(Aqua) 배경
	case 5: bgColorSelection = '4'; break; // 빨강(Red) 배경
	case 6: bgColorSelection = '5'; break; // 자주(Purple) 배경
	case 7: bgColorSelection = '6'; break; // 갈색(Brown) 배경
	case 8: bgColorSelection = '7'; break; // 회백(Gray) 배경
	default:
		printf("Invalid choice.");
		return;
	}

	char command[13];
	sprintf(command, "color %c%c", bgColorSelection, colorSelection);
	system(command);
}

void printInputArray(void) {
	system("cls");
    for (int i = 0; i < inputIndex-1; i++) {
        printf("%c", inputarray[i]);
    }
    printf("\n아무 키나 눌러서 돌아갑니다...");
    getch();
}

void display_phone_pad(void)
{
              //[함수 10.2.2]의 정의 부분 참고
	int y, x, z, cnt=0;
    	draw_check02(3, 4);
	for(y=2;y<=8;y+=3)
	{
		for(x=3;x<=15;x+=6)
		{
			gotoxy(x, y);
			printf(" %d", ++cnt); //공백1칸추 
			gotoxy(x+1, y+1);
			for(z=0;z<=2;z+=1)
				printf("%c", alpha[cnt][z]);
		}
	}
	gotoxy(9, 11);
	printf(" 0"); //공백1칸 추가 
	gotoxy(10, 12);
	printf("SP");
	gotoxy(1, 15);
}

void control_phone_pad(void)
{
       //[함수 10.2.1]의 정의 부분 참고
        char c1, c2, cnt;
        time_t start, end;
	printf("숫자키 입력>");
	c1=getch();
	
	start=time(NULL);
	do
	{	if(beepcheck == true){
			Beep(750,200); 
		}
		if(c1=='q'){
			return ;
		}
		cnt=0;
		if (c1==' ')
			printf("\b \b");
		else{
			
			printf("%c", alpha[c1-'0'][cnt]);
			if(inputIndex < sizeof(inputarray) - 1) { // 공간이 충분할 때만 추가합니다.
                inputarray[inputIndex++] = alpha[c1-'0'][cnt];
                inputarray[inputIndex] = '\0'; // 현재까지의 입력을 문자열로 만들어 줍니다.
            } else {
                printf("입력 가능한 최대 길이를 초과하였습니다.\n");
                return;
            }
		}
		if (c1=='e'){
			printf("\n");
			printf("숫자키 입력>");
			inputarray[inputIndex++] = '\n';

		}
			
		do
		{
			
			c2=getch();
			end=time(NULL);
			if ((c1==c2) && ((end-start)<=2) && c2 != ' ') // 삭제 추가 
			{
				if(beepcheck == true){
					Beep(750,200); 
				}
				if (cnt>1)
					cnt=0;
				else
					cnt++;
				c1=c2;
				printf("\b%c", alpha[c1-'0'][cnt]);
				
				start=time(NULL);
			}
			else
				break;
			
		}while(1);
		start=time(NULL);
		c1=c2;
	}while(1); 

} 
void draw_check02(int c, int r)
{
	//[함수 3.5.4]를 확장하여 사용 
    int i, j;
    unsigned char a=0xa6;
    unsigned char b[12]; 
    for(i=1;i<12;i++)
		b[i]=0xa0+i;
    printf("%c%c",a, b[3]);

    
    for(i=0;i<c+2;i++) // c-1 -> c+2
    {
		printf("%c%c%c%c", a, b[1], a, b[1]);
		printf("%c%c", a, b[8]);
    }
    printf("%c%c%c%c", a, b[1], a, b[1]);
    printf("%c%c", a, b[4]);
    printf("\n");
    for(i=0;i<r-1;i++)
    {
		printf("%c%c", a, b[2]);
		for(j=0;j<c;j++)
		{
			printf("     "); // 공백1칸 추 
			printf("%c%c",a, b[2]);
		}
		printf("\n");
		//
		printf("%c%c", a, b[2]);
		for(j=0;j<c;j++)
		{
			printf("     ");
			printf("%c%c",a, b[2]);
		}
		printf("\n");
		//
		printf("%c%c", a, b[7]);
		for(j=0;j<c+2;j++) // c-1 -> c+2
		{
			printf("%c%c%c%c", a, b[1], a, b[1]);
			printf("%c%c", a, b[11]);
		}
		printf("%c%c%c%c", a, b[1], a, b[1]);
		printf("%c%c",a, b[9]);
		printf("\n");
    }
    printf("%c%c", a, b[2]);
    for(j=0;j<c;j++)
    {
		printf("     ");
		printf("%c%c",a, b[2]);
    }
    printf("\n");
	//
	printf("%c%c", a, b[2]);
	for(j=0;j<c;j++)
	{
		printf("     ");
		printf("%c%c",a, b[2]);
	}
	printf("\n");
	//
    printf("%c%c", a, b[6]);
    for(i=0;i<c+2;i++) // c-1 -> c+2
    {
		printf("%c%c%c%c", a, b[1], a, b[1], a, b[1]);
		printf("%c%c", a, b[10]);
    }
	printf("%c%c%c%c", a, b[1], a, b[1], a, b[1]);
    printf("%c%c", a, b[5]);
    printf("\n");
}

void gotoxy(int x, int y)
{
   COORD Pos = {x - 1, y - 1};
   SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), Pos);
}
