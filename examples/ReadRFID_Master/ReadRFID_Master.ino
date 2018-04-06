#include "SPI.h"
#include "MFRC522.h"
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x3F, 20, 4);

#define SS_PIN 10
#define RST_PIN 9

int i;
int k;
bool flag1 = 0;
bool flag2 = 0;
bool tapCardX1 = 0;
bool tapCardX2 = 0;

byte admin[]={0xDB, 0x7A, 0x3D, 0xD9};
byte Xe1[]={0xF1, 0xA7, 0x3B, 0x5B};
byte Xe2[]={0x18, 0x5E, 0xA8, 0x89};

boolean match = false;
MFRC522 RFID(SS_PIN, RST_PIN);

byte readCard[4];
boolean checkTwo(byte a[], byte b[])
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
//  Serial.println("Scanned PICC's UID: ");
  for(byte i=0; i<RFID.uid.size; i++)
  {
    readCard[i] = RFID.uid.uidByte[i];
  }
//////////////////////////////////////////////////////////////////////
  String strID = "";
  for (byte i = 0; i < 4; i++) 
  {
    strID += (RFID.uid.uidByte[i] < 0x10 ? "0" : "") + String(RFID.uid.uidByte[i], HEX) + (i!=3 ? ":" : "");
  }
  strID.toUpperCase();

  //Serial.print("Tap card key: ");
  //Serial.println(strID);
//////////////////////////////////////////////////////////////////////
  //Serial.println();
  RFID.PICC_HaltA(); //Stopreading
  if(checkTwo(readCard,Xe1))
  {
    //mode1();
    if(flag1 == 0)
    {
      Serial.println("X1M");
      flag1 = 1;
    }
    else if (flag1 == 1)
    {
      Serial.println("X1T");
      flag1 = 0;
    }
  }
  else if(checkTwo(readCard,Xe2))
  {
    //mode2();
    if(flag2 == 0)
    {
      Serial.println("X2M");
      flag2 = 1;
    }
    else if (flag2 == 1)
    {
      Serial.println("X2T");
      flag2 = 0;
    }
  }
}
//void mode1()
//{
//  if(flag1 == 0)
//  {
//    Serial.println("X1M");
//    flag1 = 1;
//  }
//  else if (flag1 == 1)
//  {
//    Serial.println("X1T");
//    flag1 = 0;
//  }
//}
//void mode2()
//{
//  if(flag2 == 0)
//  {
//    Serial.println("X2M");
//    flag2 = 1;
//  }
//  else if (flag2 == 1)
//  {
//    Serial.println("X2T");
//    flag2 = 0;
//  }
//}
void setup()
{
  Serial.begin(9600);
  while(!Serial);
  SPI.begin();
  RFID.PCD_Init();
  lcd.begin();
  lcd.backlight();
  lcd.setCursor(3, 0);
  lcd.print("TRUONG DAI HOC"); 
  lcd.setCursor(2, 1); 
  lcd.print("SU PHAM KY THUAT");
  lcd.setCursor(0, 2);
  lcd.print("He Thong Cho Thue Xe");
  lcd.setCursor(5, 3);
  lcd.print("Thong Minh");
  delay(3000);
  lcd.clear();
}
void loop()
{
  readCards();
  delayMicroseconds(10);
}




