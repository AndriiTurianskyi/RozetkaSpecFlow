Feature: AddToCart
Check if the add to cart functionality works

@mytag
Scenario: Add product to cart
	Given i opened home page "Rozetka" site
	When i search for a product by product ID "191882153" in the search field
	And i add product to cart
	Then i check if the item has been added to the cart