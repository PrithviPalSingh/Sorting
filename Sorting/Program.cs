﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "1 1 1 5 6 9 10 11 13 13 15 15 16 18 18 19 22 24 26 35 36 38 44 45 50 52 53 58 58 64 68 72 73 88 89 89 90 91 91 95 108 112 115 118 128 128 128 129 129 133 135 135 136 137 140 140 141 141 143 143 148 148 158 159 159 162 163 164 165 166 169 170 170 171 172 174 188 191 192 199 205 206 210 214 221 221 222 224 228 235 237 237 239 243 255 256 261 261 261 266 268 278 281 281 282 282 283 288 291 293 293 293 294 294 297 300 309 317 321 321 324 325 326 333 336 336 338 340 340 342 344 347 349 350 351 354 357 359 361 362 367 369 372 372 375 376 377 378 383 383 383 392 393 397 401 401 402 410 411 411 412 414 418 419 422 423 423 423 429 433 434 440 440 445 447 449 452 458 458 459 459 462 462 465 466 466 467 471 476 482 483 485 486 487 488 491 491 493 493 495 498 500 501 504 505 512 512 513 516 521 521 523 524 524 526 530 531 534 535 535 536 537 539 539 541 543 546 549 551 554 555 558 561 563 564 564 567 568 568 570 570 570 571 577 586 588 590 597 597 603 603 604 606 609 615 617 621 621 621 624 627 629 630 631 632 634 635 637 639 642 645 648 654 655 661 661 662 670 674 675 675 682 684 686 691 694 695 695 697 698 698 700 706 708 709 709 711 717 721 722 722 725 729 733 736 739 741 743 744 748 749 752 755 755 756 760 760 765 767 768 769 770 781 781 782 783 785 787 789 791 794 798 799 801 803 807 808 808 808 811 812 812 814 816 824 827 833 833 834 834 835 837 840 841 855 855 856 862 863 864 866 868 870 870 871 873 874 879 880 881 884 884 885 888 895 896 900 902 902 903 907 917 924 925 926 927 930 931 937 938 942 943 943 943 950 951 952 953 956 957 958 959 959 967 969 969 974 974 977 978 979 982 984 984 985 987 987 990 997 998 1000 1 8 8 9 14 15 30 35 37 38 39 43 43 44 48 53 54 56 57 58 68 70 70 70 72 72 79 79 83 87 91 94 96 97 97 105 106 107 108 108 109 110 111 115 118 119 121 124 124 126 127 130 136 137 138 142 143 145 151 152 156 161 162 162 165 170 176 180 181 183 185 187 188 194 195 196 201 201 204 208 209 210 211 211 213 217 228 230 236 236 239 242 243 247 250 251 251 252 252 254 257 258 259 260 261 261 264 265 265 266 272 276 278 282 284 287 288 291 291 292 295 295 296 298 298 301 303 303 306 309 311 314 314 319 320 320 321 325 326 329 330 336 345 346 352 354 359 363 365 367 367 368 368 370 371 377 382 385 389 393 395 400 402 402 408 409 411 411 413 415 417 422 424 429 429 429 429 431 434 434 436 436 441 444 445 448 448 448 449 449 451 457 459 463 468 473 482 486 486 491 496 497 500 502 503 503 506 507 509 511 514 514 515 526 529 531 540 541 543 550 550 551 552 555 555 555 556 556 556 557 557 559 561 564 564 565 566 573 574 580 583 589 590 590 590 595 596 602 602 624 626 627 627 629 629 629 631 631 632 632 633 635 638 640 641 642 645 645 646 649 652 652 658 659 659 660 663 665 670 675 677 682 683 683 685 689 691 694 696 699 700 701 702 705 711 712 713 719 719 720 720 724 725 727 730 730 731 734 734 737 737 738 739 745 747 752 759 759 760 761 764 767 769 770 773 776 777 778 782 785 787 790 791 791 796 796 797 800 800 802 803 804 805 806 807 808 812 826 827 834 834 835 835 836 841 843 847 849 852 853 854 855 857 858 859 860 861 862 862 864 866 876 877 879 879 881 883 883 886 890 893 894 897 901 902 903 905 912 915 925 925 927 928 932 935 935 945 946 947 947 947 947 948 950 950 951 951 952 956 957 959 961 964 968 971 973 975 978 984 985 991 997";
            //int[] arr = Array.ConvertAll(str.Split(' '), int.Parse);
            //BinaryArraySorting.fnBinaryArraySorting1(arr);

            //TripletFamily.fnTripletFamily(new int[] { 1, 2, 3, 4, 5 });

            //InsertionSort.fnInsertionSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            //QuickSort.fnQuickSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            RelativeSorting.fnRelativeSorting(new int[] { 2, 1, 2, 5, 7, 1, 9, 3, 6, 8, 8 },
                new int[] { 2, 1, 8, 3 });
            Console.Read();
        }
    }
}