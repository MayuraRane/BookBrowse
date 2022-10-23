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

### Requirement 100.0: Search for Books

#### Scenario

As a user interested in books, I want to be able to search for based on any part of the name or the ISBN and get information about the book

#### Dependencies

Book information is available

#### Assumptions

All book names are stated in English 
 
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


**Then** when I navigate to the Specimen History view, I should see at least one Malus domestica ‘Fuji’ specimen with the a photo of a Fuji apple seedling.  
## Team Members

- Vamsi Kalepu
- Mayura Rane
- Monica Varu
- Sandeep Susarla

## Weekly Meeting

Monday at 7 PM on Teams

