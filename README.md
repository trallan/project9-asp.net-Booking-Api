# project9-asp.net-Booking-Api
Booking system for gym/workout

# Kravspecifikation

## Modeller (data-klasser)
- **Customer**  
  - Id  
  - Name  
  - Email  

- **Class**  
  - Id  
  - Title  
  - Description  
  - StartTime  

- **Booking**  
  - Id  
  - CustomerId  
  - ClassId  
  - BookingDate  

---

## Endpoints (controllers/actions)

### CustomerController
- `GET api/customers` → Hämta alla kunder  
- `GET api/customers/{id}` → Hämta en specifik kund  
- `POST api/customers` → Skapa ny kund  
- `PUT api/customers/{id}` → Uppdatera specifik kund  
- `DELETE api/customers/{id}` → Ta bort specifik kund  

### ClassController
- `GET api/classes` → Hämta alla träningspass  
- `GET api/classes/{id}` → Hämta ett specifikt pass  
- `POST api/classes` → Lägg till nytt pass
- `PUT api/classes/{id}` → Uppdatera specifik klass
- `DELETE api/classes/{id}` → Ta bort specifik klass  

### BookingController
- `GET api/bookings` → Hämta alla bokningar  
- `POST api/bookings` → Skapa en ny bokning (kopplar kund till pass)
- `PUT api/bookings/{id}` → Uppdatera specifik bookning  
- `DELETE api/bookings/{id}` → Ta bort specifik bookning  

---

## Regler
- En kund kan bara boka ett pass **en gång**.  
- En bokning måste ha en giltig **CustomerId** och **ClassId**.  

---

## 📂 Struktur
```text
Controllers/
    CustomerController.cs
    ClassController.cs
    BookingController.cs
Models/
    Customer.cs
    Class.cs
    Booking.cs
Services/  (valfritt om du vill lägga logik här)


## ⭐ Extra utmaningar (om du vill ta det längre)
- Lägg till `DELETE` för att avboka pass.  ✅
- Lägg till validering (t.ex. Email ska vara korrekt format).  ✅
- Lägg till en enkel **in-memory databas** (t.ex. en lista) eller **EF Core**.  🎯

---

## 👉 Uppgiften
Bygg detta API och se till att man kan:  
1. Skapa kunder och pass  ✅
2. Göra bokningar mellan dem  ✅
3. Hämta listor på kunder, pass och bokningar  ✅
4. Lägg till frontend 🎯