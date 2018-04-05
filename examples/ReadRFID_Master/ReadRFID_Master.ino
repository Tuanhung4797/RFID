#include "SPI.h"
#include "MFRC522.h"
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27, 20, 4);

#define SS_PIN 10
#define RST_PIN 9
//#define SP_PIN 8

MFRC522 rfid(SS_PIN, RST_PIN);

MFRC522::MIFARE_Key key;

void setup() 
{
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
  lcd.begin();
  lcd.backlight();
  lcd.setCursor(0, 4);
  lcd.print("TRUONG DAI HOC"); 
  lcd.setCursor(1, 4); 
  lcd.print("SU PHAM KY THUAT");
  lcd.setCursor(2, 1);
  lcd.print("He Thong Cho Thue Xe");
  lcd.setCursor(3, 6);
  lcd.print("Thong Minh");
  delay(3000);
  lcd.clear();
}

void loop() 
{
  if (!rfid.PICC_IsNewCardPresent() || !rfid.PICC_ReadCardSerial())
  {
    return;
  }
  // Serial.print(F("PICC type: "));
  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);
  // Serial.println(rfid.PICC_GetTypeName(piccType));

  // Check is the PICC of Classic MIFARE type
  if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI && piccType != MFRC522::PICC_TYPE_MIFARE_1K && piccType != MFRC522::PICC_TYPE_MIFARE_4K) 
  {
    Serial.println(F("Your tag is not of type MIFARE Classic."));
    return;
  }

  String strID = "";
  for (byte i = 0; i < 4; i++) 
  {
    strID += (rfid.uid.uidByte[i] < 0x10 ? "0" : "") + String(rfid.uid.uidByte[i], HEX) + (i!=3 ? ":" : "");
  }
  strID.toUpperCase();

  Serial.print("Tap card key: ");
  Serial.println(strID);

  if(strID.indexOf("F4:BD:1B:DC")>=0) 
  { 
    //// code ////
  }

  else 
  {
    //// code ////
  }

  rfid.PICC_HaltA();
  rfid.PCD_StopCrypto1();
}
