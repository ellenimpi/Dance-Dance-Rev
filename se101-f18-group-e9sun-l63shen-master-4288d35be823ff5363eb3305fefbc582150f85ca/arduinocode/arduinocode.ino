
#include <Keyboard.h>

int upStatus=1;
int upStatusPrev=1;
int leftStatus=1;
int leftStatusPrev=1;
int downStatus=1;
int downStatusPrev=1;
int rightStatus=1;
int rightStatusPrev=1;

void setup()
{
  pinMode(4,INPUT_PULLUP);
  pinMode(5,INPUT_PULLUP);
  pinMode(6,INPUT_PULLUP);
  pinMode(7,INPUT_PULLUP);
  Keyboard.begin();
}

void loop()
{
 
 upStatus=digitalRead(4);
 leftStatus=digitalRead(5);
 downStatus=digitalRead(6);
 rightStatus=digitalRead(7);
 

 if (upStatus!=upStatusPrev && upStatus==LOW)
 {
    Keyboard.press('w');
    upStatusPrev=upStatus;
 }
 if (upStatus!=upStatusPrev && upStatus==HIGH)
 {
    Keyboard.release('w');
    upStatusPrev=upStatus;
 }
 if (leftStatus!=leftStatusPrev && leftStatus==LOW)
 {
    Keyboard.press('a');
    leftStatusPrev=leftStatus;
 }
 if (leftStatus!=leftStatusPrev && leftStatus==HIGH)
 {
    Keyboard.release('a');
    leftStatusPrev=leftStatus;
 }
 
  //DOWN ARROW PRESSED
 if (downStatus!=downStatusPrev && downStatus==LOW)
 {
    Keyboard.press('s');
    downStatusPrev=downStatus;
 }
 //DOWN ARROW RELEASED
 if (downStatus!=downStatusPrev && downStatus==HIGH)
 {
    Keyboard.release('s');
    downStatusPrev=downStatus;
 }
 
 //RIGHT ARROW PRESSED
 if (rightStatus!=rightStatusPrev && rightStatus==LOW)
 {
    Keyboard.press('j');
    rightStatusPrev=rightStatus;
 }
 //RIGHT ARROW RELEASED
 if (rightStatus!=rightStatusPrev && rightStatus==HIGH)
 {
    Keyboard.release('j');
    rightStatusPrev=rightStatus;
 }
}
