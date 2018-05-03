#include "SPI.h"
#include "MFRC522.h"
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x3F, 20, 4);

#define SS_PIN 10
#define RST_PIN 9

#define speak 6
#define relay1  7
#define relay2  8
////////////////// Var of read to serial /////////////////////
const int MAX_BUF      = 64;
char buffer[MAX_BUF];
int sofar;

unsigned int moneyX1;
int moneyX2;
int gioX1M;
int phutX1M;
int timeTx1;
int timeMx2;
int timeTx2;
///////////////////////////////////////
int i;
int k;
bool flag1 = 0;
bool flag2 = 0;
bool flagAd = 0;
bool tapCardX1 = 0;
bool tapCardX2 = 0;

byte admin1[]={0xDB, 0x7A, 0x3D, 0xD9};
byte admin2[]={0xD3, 0x58, 0x80, 0x63};
byte Xe1[]={0xF1, 0xA7, 0x3B, 0x5B};
byte Xe2[]={0x18, 0x5E, 0xA8, 0x89};

boolean match = false;
MFRC522 RFID(SS_PIN, RST_PIN);

byte readCard[4];
boolean checkCard(byte a[], byte b[])
{
  if(a[0] != NULL)
    match = true;
  for(int k=0; k<4; k++)
  {
    if(a[k]!=b[k])
      match = false;
  }
  if(match)
  {
    return true;
  }
  else
  {
    return false;
  }
}
byte readCards()
{
  if(! RFID.PICC_IsNewCardPresent())
  {
    //If a new PICC placed to RFID reader continue
    return 0;
  }
  if (! RFID.PICC_ReadCardSerial())
  {
    //Since a PICC placed get Serial and continue
    return 0;
  }
  for(byte i=0; i<RFID.uid.size; i++)
  {
    readCard[i] = RFID.uid.uidByte[i];
  }
  String strID = "";
  for (byte i = 0; i < 4; i++) 
  {
    strID += (RFID.uid.uidByte[i] < 0x10 ? "0" : "") + String(RFID.uid.uidByte[i], HEX) + (i!=3 ? ":" : "");
  }
  strID.toUpperCase();
  RFID.PICC_HaltA(); //Stopreading
  /////////////// check the card ///////////////////////// 
  if(checkCard(readCard,Xe1))
  {
    if(flag1 == 0)
    {
      Serial.println("X1M");
      readToSerial();
      unlockX1();
      flag1 = 1;
    }
    else if (flag1 == 1)
    {
      Serial.println("X1T");
      readToSerial();
      unlockX1();
      flag1 = 0;
    }
  }
  else if(checkCard(readCard,Xe2))
  {
    if(flag2 == 0)
    {
      Serial.println("X2M");
      unlockX2();
      flag2 = 1;
    }
    else if (flag2 == 1)
    {
      Serial.println("X2T");
      unlockX2();
      flag2 = 0;
    }
  }
  else if(checkCard(readCard,admin1))
  {
    if(flagAd == 0)
    {
      adminUnlock();
      flagAd = 1;
    }
    else if(flagAd == 1)
    {
      adminLock();
      flagAd = 0;
    }
  }
  else if(checkCard(readCard,admin2))
  {
    if(flagAd == 0)
    {
      adminUnlock();
      flagAd = 1;
    }
    else if(flagAd == 1)
    {
      adminLock();
      flagAd = 0;
    }
  }
}
void printLCD()
{
  lcd.clear();
  lcd.setCursor(0 ,0);
  lcd.print("Xac nhan tra xe so 1");
  lcd.setCursor(0 ,1);
  lcd.print("Gio lay: ");
  lcd.setCursor(9, 1);
  lcd.print(gioX1M);
  lcd.setCursor(11 ,1);
  lcd.print(":");
  lcd.setCursor(12 ,1);
  lcd.print(phutX1M);
//  lcd.setCursor(0, 2);
//  lcd.print("Gio tra: ");
//  lcd.setCursor(10, 2);
//  lcd.print(timeTx1);
//  lcd.setCursor(0, 3);
//  lcd.print(tien1);
}
void unlockX1()
{
  switch(flag1)
  {
    case 0:
      digitalWrite(relay1, LOW);
      //readToSerial();
//      lcd.clear();
//      lcd.setCursor(0 ,0);
//      lcd.print("Xac nhan lay xe so 1");
//      lcd.setCursor(0 ,1);
//      lcd.print("Gio lay: ");
//      lcd.setCursor(10, 1);
//      lcd.print(gioX1M);
      delay(30000);
      digitalWrite(relay1, HIGH);
      lcd.clear();
      homeLCD();
      break;
    case 1:
    	//moneyX1 = Serial.read();
      digitalWrite(relay1, LOW);
      //readToSerial();
//      lcd.clear();
//      lcd.setCursor(0 ,0);
//      lcd.print("Xac nhan tra xe so 1");
//      lcd.setCursor(0 ,1);
//      lcd.print("Gio lay: ");
//      lcd.setCursor(10, 1);
//      lcd.print(timeMx1);
//      lcd.setCursor(0, 2);
//      lcd.print("Gio tra: ");
//      lcd.setCursor(10, 2);
//      lcd.print(timeTx1);
//      lcd.setCursor(0, 3);
//      lcd.print(moneyX1);
      
      delay(30000);
      digitalWrite(relay1, HIGH);
      lcd.clear();
      homeLCD();
      break;
  }
}
void unlockX2()
{
  switch(flag2)
  {
    case 0:
      digitalWrite(relay2, LOW);
      //readToSerial();
      lcd.clear();
      lcd.setCursor(0 ,0);
      lcd.print("Xac nhan lay xe so 2");
      lcd.setCursor(0 ,1);
      lcd.print("Gio lay: ");
      lcd.setCursor(10, 1);
      lcd.print(timeMx2);
      delay(30000);
      digitalWrite(relay2, HIGH);
      lcd.clear();
      homeLCD();
      break;
    case 1:
      digitalWrite(relay2, LOW);
      //readToSerial();
      lcd.clear();
      lcd.setCursor(0 ,0);
      lcd.print("Xac nhan tra xe so 2");
      lcd.setCursor(0 ,1);
      lcd.print("Gio lay: ");
      lcd.setCursor(10, 1);
      lcd.print(timeMx2);
      lcd.setCursor(0, 2);
      lcd.print("Gio tra: ");
      lcd.setCursor(10, 2);
      lcd.print(timeTx2);
      lcd.setCursor(0, 3);
      lcd.print(moneyX2);
      delay(30000);
      digitalWrite(relay2, HIGH);
      lcd.clear();
      homeLCD();
      break;
  }
}
void adminUnlock()
{
  digitalWrite(relay1, LOW);
  digitalWrite(relay2, LOW);
  lcd.clear();
  lcd.setCursor(7, 0);
  lcd.print("Admin");
  lcd.setCursor(7, 2);
  lcd.print("Unlock");
}
void adminLock()
{
  digitalWrite(relay1, HIGH);
  digitalWrite(relay2, HIGH);
  lcd.clear();
  lcd.setCursor(8, 0);
  lcd.print("Admin");
  lcd.setCursor(8, 2);
  lcd.print("Lock");
}
void speaks(int t, int n)
{
  for(int i=0; i<n; i++)
  {
    digitalWrite(speak, HIGH);
    delay(t);
    digitalWrite(speak, LOW);
    delay(t);
  }
}
void homeLCD()
{
  lcd.setCursor(3, 0);
  lcd.print("TRUONG DAI HOC"); 
  lcd.setCursor(2, 1); 
  lcd.print("SU PHAM KY THUAT");
  lcd.setCursor(0, 2);
  lcd.print("He Thong Cho Thue Xe");
  lcd.setCursor(5, 3);
  lcd.print("Thong Minh");
}
void setup()
{
  Serial.begin(9600);
  while(!Serial);
  SPI.begin();
  RFID.PCD_Init();
  lcd.begin();

  pinMode(relay1, OUTPUT);
  pinMode(relay2, OUTPUT);
  pinMode(speak, OUTPUT);
  lcd.backlight();
  lcd.setCursor(3, 0);
  lcd.print("TRUONG DAI HOC"); 
  lcd.setCursor(2, 1); 
  lcd.print("SU PHAM KY THUAT");
  lcd.setCursor(0, 2);
  lcd.print("He Thong Cho Thue Xe");
  lcd.setCursor(5, 3);
  lcd.print("Thong Minh");
}

////////////// read to serial /////////////////

void processCommand() {
  
  if( !strncmp(buffer,"borrowX1",8))
  {
    char *ptr=buffer;
    while(ptr && ptr<buffer+sofar)
    {
      ptr=strchr(ptr,' ')+1;
      switch(*ptr)
      {
        case 'H': gioX1M=atof(ptr+1); break;
        case 'M': phutX1M=atof(ptr+1); break;
        default: ptr=0; break;
      }
    }
    delay(2000);
    printLCD();
    //Robot.moveArm(Base, Shoulder, Elbow, Grip, speed);
  }
  else if( !strncmp(buffer,"payX1",5))
  {
    char *ptr=buffer;
    while(ptr && ptr<buffer+sofar)
    {
      ptr=strchr(ptr,' ')+1;
      switch(*ptr)
      {
        case 'B': timeTx1=atof(ptr+1); break;
        case 'C': moneyX1=atof(ptr+1); break;
        default: ptr=0; break;
      }
      
    }
    //Robot.moveArm(Base, Shoulder, Elbow, Grip, speed);
    printLCD();
  }
  else if( !strncmp(buffer,"borrowX2",8))
  {
    char *ptr=buffer;
    while(ptr && ptr<buffer+sofar)
    {
      ptr=strchr(ptr,' ')+1;
      switch(*ptr)
      {
        case 'D': timeMx2=atof(ptr+1); break;
        default: ptr=0; break;
      }
    }
    //Robot.moveArm(Base, Shoulder, Elbow, Grip, speed);
  }
  else if( !strncmp(buffer,"payX2",5))
  {
    char *ptr=buffer;
    while(ptr && ptr<buffer+sofar)
    {
      ptr=strchr(ptr,' ')+1;
      switch(*ptr)
      {
        case 'E': timeTx2=atof(ptr+1); break;
        case 'F': moneyX2=atof(ptr+1); break;
        default: ptr=0; break;
      }
    }
    //Robot.moveArm(Base, Shoulder, Elbow, Grip, speed);
  }
}
void readToSerial()
{
  while(Serial.available() > 0)
  {
    buffer[sofar++]=Serial.read();
    if(buffer[sofar-1]==';') break;  // in case there are multiple instructions
  }
  // if we hit a semi-colon, assume end of instruction.
  if(sofar>0 && buffer[sofar-1]==';')
  {
    buffer[sofar]=0;
    //// echo confirmation
    //Serial.println(buffer);
    //// do something with the command
    processCommand();
    // reset the buffer
    sofar=0;
    //// echo completion
    //Serial.print(F("> "));
  }
}

//////////////////////////////////////////////
void loop()
{
  //homeLCD();
  //readToSerial();
  readCards();
  delayMicroseconds(10);
}




