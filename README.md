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
- `GET /customers` → Hämta alla kunder  
- `GET /customers/{id}` → Hämta en specifik kund  
- `POST /customers` → Skapa ny kund  

### ClassController
- `GET /classes` → Hämta alla träningspass  
- `GET /classes/{id}` → Hämta ett specifikt pass  
- `POST /classes` → Lägg till nytt pass  

### BookingController
- `GET /bookings` → Hämta alla bokningar  
- `POST /bookings` → Skapa en ny bokning (kopplar kund till pass)  

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
- Lägg till `DELETE` för att avboka pass.  
- Lägg till validering (t.ex. Email ska vara korrekt format).  
- Lägg till en enkel **in-memory databas** (t.ex. en lista) eller **EF Core**.  

---

## 👉 Uppgiften
Bygg detta API och se till att man kan:  
1. Skapa kunder och pass  
2. Göra bokningar mellan dem  
3. Hämta listor på kunder, pass och bokningar  
