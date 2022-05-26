### API Spec for Review Website

#### Models
User
    - Guid Id
    - Reviews[] Posts
    - String FirstName
    - String LastName
    - String Email
    - DateTime CreatedAt
    
Review
    - Guid Id
    - String Content
    - String Heading
    - Int Upvotes
    - Comment[] Comments
    - User -> FK
    - Category Category

Comment
    - Comment Id
    - Guid UserId -> FK
    - String Content
    - Int Upvotes

Category
    - String Name
    - Guid Id
    - Review[] Reviews