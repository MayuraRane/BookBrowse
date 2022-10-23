# Books Project

--- 

## Introduction 

Book Club is a goto website for passionate readers. We have a wide-range of collection for readers who'd like to choose what their next book is going to be. We enable readers to choose from a list of genres, search by ISBN or author. 

Our services include:
	- Choose the next book you're going to read
	- Search from a range of genres or by authors you follow
  	- Simplify your search if you know the ISBN

## Data Feeds
[Goodreads API](https://www.goodreads.com/api)

[NY Times API](https://developer.nytimes.com/docs/books-product/1/overview)

[Amazon Best Selling Books Dataset](https://www.kaggle.com/datasets/sootersaalu/amazon-top-50-bestselling-books-2009-2019)


## Functional Requirements

#### Assumptions

English is the only language used for all searches.

#### Dependencies

1) Book Information is available
2) Author Information is available

### Requirement 1: Search for Books

#### Scenario

As a user interested in books, I want to be able to search for based on any part of the name or the ISBN and get information about the book
 
#### Examples

1.1  
**Given** a feed of book data is available  

**When** I search for “Atomic Habits”  

**Then** I should receive:  

Book Title: Atomic Habits  

Author: James Clear

Genre: Self-help book

Description: Summary of book  

1.2  
**Given** a feed of book data is available  

**When** I search for “9783442178582”  

**Then** I should receive:  

Book Title: Atomic Habits  

Author: James Clear

Genre: Self-help book

Description: Summary of book  

### Requirement 2: Search for Author and get books

### Scenario

As a user, I want to look up authors so that I can learn more about them and acquire a list of their published works so I can read more (perhaps because I liked one of their novels or books).

#### Examples

2.1
**Given** a feed of author data is available

**When** I search for "J. K. Rowling"

**Then** I should receive:

Author: J. K. Rowling

Bio: J.K. Rowling is the famous British author of the worldwide attention gaining Harry Potter series. Her best-selling novels have sold more than 400 million copies and won numerous awards. The books have also been adapted to screen in a series of blockbuster films.  more...

List of books to choose:
1) Harry Potter Series
2) The Casual Vacancy
3) The Christmas Pig
4) Fantastic Beasts and Where to Find Them
Etc.

2.2
**Given** a feed of author data is available

**When** I search for "Dan Brown"

**Then** I should receive:

Author: Dan Brown

Bio: Dan Brown is the author of numerous #1 bestselling novels, including The Da Vinci Code, which has become one of the best selling novels of all time as well as the subject of intellectual debate among readers and scholars. Brown’s novels are published in 56 languages around the world with over 200 million copies in print. more...

List of Books to choose:
1) Da Vinci Code
2) Angels and Demons
3) Inferno
Etc.

### Requirement 4 : New Releases published on Home page

### Scenario:

As a User, I want to be able to view list of newly released books on the homepage so that I can get to know new books available.

## Team Members

- Vamsi Kalepu
- Mayura Rane
- Monica Varu
- Sandeep Susarla

## Weekly Meeting

Monday at 7 PM on Teams

