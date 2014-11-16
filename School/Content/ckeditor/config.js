/*
Copyright (c) 2003-2013, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function (config) {
    config.resize_enabled = false;
    config.height = 600;
    config.skin = 'v2';
    config.language = 'zh-cn';  // 中文
    config.tabSpaces = 4;       // 当用户键入TAB时，编辑器走过的空格数，当值为0时，焦点将移出编辑框
    config.toolbar = "Full";    // 工具条配置
    config.toolbar_Full = [
['Source', '-', 'Save', 'NewPage', 'Preview', '-', 'Templates'],
['Cut', 'Copy', 'Paste', 'PasteText', 'PasteFromWord', '-', 'Print', 'SpellChecker', 'Scayt'],
['Undo', 'Redo', '-', 'Find', 'Replace', '-', 'SelectAll', 'RemoveFormat'],
['Form', 'Checkbox', 'Radio', 'TextField', 'Textarea', 'Select', 'Button', 'ImageButton', 'HiddenField'],
'/',
['Bold', 'Italic', 'Underline', 'Strike', '-', 'Subscript', 'Superscript'],
['NumberedList', 'BulletedList', '-', 'Outdent', 'Indent', 'Blockquote'],
['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
['Link', 'Unlink', 'Anchor'],
['Image', 'Flash', 'Table', 'HorizontalRule', 'Smiley', 'SpecialChar', 'PageBreak'],
'/',
['Styles', 'Format', 'Font', 'FontSize'],
['TextColor', 'BGColor']
];
};
