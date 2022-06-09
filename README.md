# CourierKata
You work for a courier company and have been tasked with creating a code library to
calculate the cost of sending an order of parcels.\
● You may approach this in the language you feel most comfortable using.\
● The API for the library should be programmatic. There is no need to
implement a CLI, HTTP, or any other transport layer.\
● Try not to peek ahead at future steps and commit your work as you go.\
● Input can be in any form you choose.\
● Output should be a collection of items with their individual cost and type, as
well as total cost.\
● In all circumstances the cheapest option for sending each parcel should be
selected.\
● You are expected to use test driven development (TDD).\
Take no longer than 2 hours! Do what you can and give us a rough outline of what further
changes you might consider making.

## Assumptions
● From the documentation, all numbers used were integers. I chose to use integers for all package dimensions, weight and costs. In reality, I would have checked with the product owner for the suitable units to use.\
● As the cheapest combination had to be used, I chose to turn a package into a heavy package if that would make it cheaper, even if it was below the 50k. I did this as it would not make sense to have a package that could save cost by adding more weight.\
● The example output had all the items on the same line. In reality, the printed order would likely print one item per line.\

## Notes
● It became evident that I was not going to complete all stages within the 2 hour time limit, so some of my implementation became a bit rushed.\
● I did not get to start part 5 of the task.\
● I might have chosen a different approach if I had a little bit more time to think about the problem.

## Further Improvements
● Add in an order line for speedy shipping. I realise that I have missed adding the speedy shipping description and cost to the output (the cost is reflected in the total though).\
● Add a service for the logic of building, checking out and printing the order.\
● Create tests with orders which have multiple packages.\
● Look at making a base parcel class and having the different pacel sizes inherit from that.\
● Create more unit tests around the different parts of the order.\
● Create some integration tests to check the full process of adding, checking out and printing the order.

## Part 5
● Taking a quick look at part 5, a recursive solution would likely have to be used to find the different combinations and prices. Adding some memoisation to this with a dictionary of results would no doubt speed up this process.
