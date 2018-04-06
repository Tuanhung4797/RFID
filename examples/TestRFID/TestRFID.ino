#include "SPI.h"
#include "MFRC522.h"
#define SS_PIN 10
#define RST_PIN 9

int i;
int k;

byte admin[]={0xDB, 0x7A, 0x3D, 0xD9};
byte Xe1[]={0xF1, 0xA7, 0x3B, 0x5B};
byte Xe2[]={0x18, 0x5E, 0xA8, 0x89};

boolean match = false;
MFRC522 RC522(SS_PIN, RST_PIN);

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
  if(! RC522.PICC_IsNewCardPresent())
  {
    //If a new PICC placed to RFID reader continue
    return 0;
  }
  if (! RC522.PICC_ReadCardSerial())
  {
    //Since a PICC placed get Serial and continue
    return 0;
  }
//  Serial.println("Scanned PICC's UID: ");
  for(byte i=0; i<RC522.uid.size; i++)
  {
    readCard[i] = RC522.uid.uidByte[i];
  }
//////////////////////////////////////////////////////////////////////
  String strID = "";
  for (byte i = 0; i < 4; i++) 
  {
    strID += (RC522.uid.uidByte[i] < 0x10 ? "0" : "") + String(RC522.uid.uidByte[i], HEX) + (i!=3 ? ":" : "");
  }
  strID.toUpperCase();

  Serial.print("Tap card key: ");
  Serial.println(strID);
//////////////////////////////////////////////////////////////////////
  Serial.println();
  RC522.PICC_HaltA(); //Stopreading
//  if(checkTwo(readCard,Xe1))
//  {
//    //Serial.println("X1M");
//  }
//  else if(checkTwo(readCard,Xe2))
//  {
//    //Serial.println("X1T");
//  }
}
void setup()
{
  Serial.begin(9600);
  while(!Serial);
  SPI.begin();
  RC522.PCD_Init();
  Serial.println("Warning: this example over writes the UID of your UID change able card, use with care!"); 
}
void loop()
{
  readCards();
  delayMicroseconds(10);
}




