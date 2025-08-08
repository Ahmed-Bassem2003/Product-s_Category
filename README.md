# ITI Final Project

## Overview
This project is a **C# console application** designed to manage **categories** and their associated **products**.  
It provides an interactive interface where the user can create categories, add products to them, and view the stored data.  
The main goal of this application is to simulate a simple product management system without using a database — all data is managed during runtime.

---

## Features
- **Add Categories**  
  Users can create new categories by entering the category name and other relevant details.
  
- **Add Products to Categories**  
  After creating a category, users can add multiple products to it.  
  Each product contains basic details such as:
  - Product name
  - Price
  - Quantity
  - Description (optional)
  
- **View All Categories**  
  The program allows users to display all categories and the products inside each one.

- **Structured Data Handling**  
  Data is stored in memory using lists or collections, making it easy to manage and update.

---

## How It Works
1. **Program Start**  
   The application displays a menu with options for:
   - Adding a category
   - Adding a product to a specific category
   - Viewing all categories and products
   - Exiting the program

2. **Adding a Category**  
   The user is prompted to enter the category name.  
   The category is then stored in an internal list.

3. **Adding a Product**  
   The user selects a category from the existing ones and enters the product details.  
   The product is then linked to that category.

4. **Viewing Data**  
   The program prints all categories, and under each category, it lists the products with their details.

---

## Installation
Follow these steps to clone and run the project locally:

 **Clone the Repository**
```bash
git clone https://github.com/Ahmed-Bassem2003/ITI_Final_Project.git
