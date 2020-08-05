@echo off
echo WARNING: This will remove ALL modules except for the ones needed to run the app! Your code will be unaffected by this operation. Press CTRL+C twice to cancel, or press ENTER to continue.
pause
del node_modules /Q /S
npm install mongoose --save
npm install semantic-ui --save
npm install react --save
npm install react-dom --save
npm install react-router-dom --save
npm install express --save
npm install jsonwebtoken --save
npm install bcryptjs --save
npm install react-ad-block-detect --save
npm install @hapi/joi --save
npm install cors --save
npm install dotenv --save
npm install body-parser --save
npm install axios --save