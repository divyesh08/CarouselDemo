### CarouselDemo

Hey, Xamarin.Forms 5.0 is available now. You may want to update Xamarin.Forms version in your running projects. But when you make this update keep this small thing mind: https://ibb.co/NW576ZW

### What's new in CarouselView?
```css
When you update Xamarin.Forms with version 5.0 you will notice one thing in CarouselView that though you have 
only single item in the ItemSource carousel will show it in a loop, that will make you think like your data is 
being duplicated, but its not like that. 

Actually now CarouselView have this behaviour by default, that it will show data in loop, so as you reach to the 
last item, it will show first item again and vice versa.
```

### How to handle this default behaviour?
- As I have mentioned Xamarin has added some new properties to all this Control. So, if you want to change it's default looping behaviour you have to use "Loop" property in xaml 

- Loop is a boolean property which is true by default, so if you set it as false than it will work like as it works before Xamarin.Forms 5

- If you want to test that, just remove the Loop property which I have set in this sample.

### Output:
<details>
  <img src="https://user-images.githubusercontent.com/10617244/104808149-4aa24d80-580a-11eb-872c-5f5e9eab1909.gif" width="200" height="400" />
</details>


### Reference: 
- https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/carouselview/interaction
