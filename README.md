# ecommerce-backend
# E-Commerce Backend (Second-Hand Platform)

## 👥 Solo Project
- [Attila Bako] – Role: Database Design,API & Backend Logic, Caching & Optimization, Cloud Integration


## 📘 Project Overview
This backend powers a second-hand e-commerce platform. Users can:
- List items for sale
- Browse listings
- Place orders
- Review sellers

The project uses modern backend architecture with NoSQL, caching, cloud storage, and CQRS.

---

## 📦 Tech Stack
- **MongoDB**: User profiles and item listings
- **PostgreSQL**: Orders and transactional data
- **Redis**: Caching frequent queries
- **AWS S3** (or simulated): Image storage
- **Node.js + Express**: Backend server

---

## 📐 Architecture (WIP)
We are using the following patterns and components:
- NoSQL + SQL hybrid
- CQRS (separate read/write)
- Redis caching
- Cloud-based media storage

---

## 🔧 How to Run (To be added)
Instructions for setting up and running the backend locally.

## ✅ MongoDB Atlas Integration
We use MongoDB Atlas to store listing data in a cloud-based NoSQL database.

- Connection is configured via `appsettings.json`
- Data access is handled through `ListingService.cs`
- Listings are stored in `EcommerceDB.Listings`
- Verified using Swagger POST and checked in MongoDB Atlas UI
