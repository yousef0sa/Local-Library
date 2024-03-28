## Local library

This Windows Forms Application provides a convenient and interactive way to explore and search for items in a JSON file. The application includes a paginated view of the items, a search feature, and a setting to change the file path of the JSON file and change the number of items displayed per page.

## Key Features

- **Paginated View:** The application displays the items in a paginated view, allowing users to navigate through the pages of items.
![alt text](https://github.com/yousef0sa/Local-Library/blob/master/Demo/displays%20the%20items%20.png?raw=true)
- **Search Feature:** Users can search for items by title with a built-in delay for more accurate search results.
![alt text](https://github.com/yousef0sa/Local-Library/blob/master/Demo/search%20for%20items.png?raw=true)
- **Link Preview:** When a user clicks on an item, the application will open the associated link in the default web browser.
![alt text](https://github.com/yousef0sa/Local-Library/blob/master/Demo/Link%20Preview.gif?raw=true)
- **Change File Path:** Users can change the file path of the JSON file through the settings feature.
- **Local Image Storage:** The application saves images to local storage for faster loading.

## Getting Started
1. [Download](https://github.com/yousef0sa/Local-Library/releases) and install for Windows
2. Set up the JSON file with the required format, including the **title**, **image**, **link**, and **info**.


```json
{
    "<Key-name>": [
        {
            "title": "string-title",
            "image": "string-URL-image",
            "link": "string-URL-link",
            "info": "string-info"
        }
    ]
}
```
3. Change the file path in the settings feature to the location of the JSON file or If you're launching the application for the first time, a window will appear asking you to specify the path.
4. Explore the items in a paginated view, search for items, and click on an item to open the associated link.


## Demo data

Feel free to [download](https://github.com/yousef0sa/Local-Library/blob/master/Demo/Demo.json) and try out the demo JSON data!
## Support

If you encounter any issues or have ideas to share, please contact us through this [support page](https://github.com/yousef0sa/Local-Library/issues/new).

