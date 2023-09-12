
#[How to install?](https://github.com/Piotrassin/DislocationCounterWinFormsApp/blob/master/README.md#how-to-install)

# DislocationCounterWinFormsApp
Simple WinForms program for counting the rough number of dark features in images using the EmguCV library.
### Disclaimer
Keep in mind that the idea behind the program is to approximate the number of shapes in a picture and the calculations may not be exact. 

#### Known limitations as of writing (12.09.2023)
- interlocking shapes are counted as one.
- large, but narrow shapes with small area (lines, cracks, etc.) may not get filtered out.

## How to use it?
The program has a panel with various settings on the left and a main area for the picture preview in the middle-right.
Settings can be adjusted either by clicking on the up/down arrows to the right of the field for fine tuning or by hovering a cursor and using the mouse wheel.
![shapeRecognitionDemo_ControlInputOptions](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/b7331835-1744-49ab-b747-416037ba833f)

If you're not sure what a given setting or button does exactly, there is a short description (tooltip) which appears after hovering the mouse over it.
![shapeRecognitionDemo_Tooltips](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/f8211cdb-ca38-40a8-af7f-79a931aaa9a6)

![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/11a8ec8e-59a8-4703-8a77-5dbbbb74df4f)

## 1. Start from importing the picture you want. 
![shapeRecognitionDemo_PictureImport](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/3fc265cc-0b2c-4b0e-b344-9218e556bac8)

## 2. Imported picture is displayed on the right. 
Now you can click either of the "Preview Filtered Shapes" if you only want to see the preview of pixels split based on the Sensitivity setting (more below) or "Count Shapes" buttons to jump straight to the result. 
If the number of counted shapes is not correct, you can tweak the settings. 
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/dc11163d-e14a-46e7-a9ff-f0bdece5a629)

## 3. Tweak the settings for the best result
### Counting the shapes
Counted shapes have perimeters highlighed in red so it can be easily seen which ones are taken into account and which ones are ignored.
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/499b0385-e14a-4684-9300-5786cb798c40)

### Sensitivity
Pixels in the picture are split into two groups based on their brightness. One group coloured in white is the group of pixels which will be processed in further steps. 
Other group coloured in black represents the ignored pixels. Sensitivity ranges from 0 to 255 and determines the threshold between the groups.
The higher the value, more and more brighter pixels will be put into the white group. 
The lower the value, more pixels will be ignored and only the darkest ones will stay in the approved group.
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/66c42b55-fbd9-4256-afdd-de3b918e7d7d)

Here you can see a comparison of different sensitivity settings
- too low (details are lost)
- optimal (shapes resemble hexagons, but no noise is visible)
- too high (a lot of noise is visible which will significantly slow further processing. Due to this, I suggest to only use the "Preview" button with noise present in the picture)

### AutoPreview
When checked, automatically displayes the preview based on current Sensitivity setting.
![shapeRecognitionDemo_AutoPreview](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/00f57088-5c2f-44cf-a528-ac038be42462)

### Minimum and Maximum Area
Those settings control the lower and upper boundaries of shapes taken into account when counting. It can be helpful if there are small or large features which weren't removed by the Sensitivity setting and they shouldn't be counted.
![shapeRecognitionDemo_MinMaxArea](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/5c3d9f5b-289e-4f87-ab51-d8572ae9a2a3)




# ===================================
# How to install?
1. Go to the "Releases" section

![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/9fadd3d5-3a8b-42fc-acb4-e7711e21d526)

2. Download the latest zip file with the version number
![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/ca9548f0-b43e-4c2e-8ec0-9e9265e87e87)

3. Unpack the archive (7zip)
4. Run the "setup.exe" on the first run, quick installation will take place.
5. On all subsequent runs you can use either the "setup.exe" or the "DislocationCounterWinForms.application"

![obraz](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/e464de32-cb6b-44b3-a999-24cab78d4072)


