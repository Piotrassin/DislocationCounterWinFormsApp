# DislocationCounterWinFormsApp
Simple WinForms program for counting the number of dark hexagonal features in images using the EmguCV library.

## How to use it?
The program has a panel with various settings on the left and a main area for the picture preview in the middle-right.
Each button and control has a short description which appears after hovering the mouse over it.
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/e1b75f26-8ecd-45c2-ab0e-a5ed7bf73bfc)

## 1. Start from importing the picture you want. 
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/379d5ab4-29be-400f-be5f-bc29dac70316)

## 2. Imported picture is displayed on the right. 
Now you can click either of the "Preview Filtered Shapes" if you only want to see the preview of pixels split based on the Sensitivity setting (more below) or "Count Shapes" buttons to jump straight to the result. 
If the number of counted shapes is not correct, you can tweak the settings. 
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/dc11163d-e14a-46e7-a9ff-f0bdece5a629)
### Sensitivity
Pixels in the picture are split into two groups based on their brightness. One group coloured in white is the group of pixels which will be processed in further steps. 
Other group coloured in black represents the ignored pixels. Sensitivity ranges from 0 to 255 and determines the threshold between the groups.
The higher the value, more and more brighter pixels will be put into the white group. 
The lower the value, more pixels will be ignored and only the darkest ones will stay in the approved group.
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/66c42b55-fbd9-4256-afdd-de3b918e7d7d)
Here you can see a comparison of different sensitivity settings
- too low (details are lost)
- optimal (shapes resemble hexagons, but no noise is visible)
- too high (a lot of noise is visible which will significantly slow further processing. Due to this, I suggested to only use the "Preview" button with noise present in the picture)


