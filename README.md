> [!NOTE]
> This is _develop branch_, so it can be updated. Temporary it is a default branch for the repo.
> It will be merged with _main branch_ after I will be ordered to do so. After that _main branch_ will be the default one.

# :eyes: Overview

This repository contains my solution to the test task provided by IFortex in January 2025.

My results and remarks about the task I put below:

## :call_me_hand: Results

Books with "Red" in their title that were published after the release of Sabaton's "Carolus Rex":

![books](/assets/img/many-books.png)

Book with the highest cost of publishing:

![book](/assets/img/single-book.png)

Authors who have written an even number of books published since 2015:

![authors](/assets/img/many-authors.png)

Author who wrote the book with the longest title:

![author](/assets/img/single-author.png)

## :mag: Details

- 0 is even, so list for 3rd condition consists of 3 authors(Frank Sidorov is author with 0 books published since 2015)
- "Something forbidden" by Ivan Karpov(Id = 2) and "Even coolest story" by Frank Sidorov(Id = 6) have same title length, so 2 as id was receive for 4th condition

## :jigsaw: Issues I faced

On first run I got unexpected exception and was totally surprised. After about 20 mins of research and check I found, that Sql Server service did not even present in my system.
Oh, yeah, I deleted Sql Server 2 weeks ago and was 100% sure that it won't be needed :upside_down_face: So i reinstalled it. Since then everything has been working great as expected.
