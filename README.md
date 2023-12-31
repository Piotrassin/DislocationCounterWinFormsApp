## How to install? Click [here](https://github.com/Piotrassin/DislocationCounterWinFormsApp/blob/master/README.md#how-to-install)

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
![shapeRecognitionDemo_ControlInputOptions](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/853217a8-c571-4f5c-9078-6c4eb4d50821)

If you're not sure what a given setting or button does exactly, there is a short description (tooltip) which appears after hovering the mouse over it.
![shapeRecognitionDemo_Tooltips](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/2d16633d-fd1d-42b4-af5b-3a0e7bd6d883)

## 1. Start from importing the picture you want. 
![shapeRecognitionDemo_PictureImport](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/ce2f2bc8-0240-4d3f-a44c-52f942ce7c97)


Imported picture is displayed on the right. 
Now you can click either of the "Preview Filtered Shapes" if you only want to see the preview of pixels split based on the Sensitivity setting (more below) or "Count Shapes" buttons to jump straight to the result. 
If the number of counted shapes is not correct, you can tweak the settings. 

## 2. Tweak the settings for the best result
### Counting the shapes
Counted shapes have perimeters highlighed in red so it can be easily seen which ones are taken into account and which ones are ignored.
![shapeRecognitionDemo_RedOutline](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/e89b4229-c805-44c1-9c5b-7cd3c118d8ca)

### Sensitivity
Pixels in the picture are split into two groups based on their brightness. One group coloured in white is the group of pixels which will be processed in further steps. 
Other group coloured in black represents the ignored pixels. Sensitivity ranges from 0 to 255 and determines the threshold between the groups.
The higher the value, more and more brighter pixels will be put into the white group. 
The lower the value, more pixels will be ignored and only the darkest ones will stay in the approved group.
![shapeRecognitionDemo_SensitivitySettings](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/c0f68d2e-419a-4d89-bd1d-d97e6ef50b82)

Here you can see a comparison of different sensitivity settings
- too low (details are lost)
- optimal (shapes resemble hexagons, but no noise is visible)
- too high (a lot of noise is visible which will significantly slow further processing. Due to this, I suggest to only use the "Preview" button with noise present in the picture)

### AutoPreview
When checked, automatically displayes the preview based on current Sensitivity setting.
![shapeRecognitionDemo_AutoPreview](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/09c19308-d678-4608-b6e2-1e90bf57f251)


### Minimum and Maximum Area
Those settings control the lower and upper boundaries of shapes taken into account when counting. It can be helpful if there are small or large features which weren't removed by the Sensitivity setting and they shouldn't be counted.
![shapeRecognitionDemo_MinMaxArea](https://github.com/Piotrassin/DislocationCounterWinFormsApp/assets/45977051/3376c4c7-b84e-4478-a5b8-2bc7fb2c0209)




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


