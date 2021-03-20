Feature: AddToCart
Check if the add to cart functionality works
@mytag
Scenario: Add product to cart
	Given opened home page "Rozetka" site
	When search for a product by product ID in the search field
	And add product to cart
	Then check if the item has been added to the cart