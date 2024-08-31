'use-client';

import React from 'react';
import { ThemeProvider } from '@mui/material/styles';
import theme from './theme'; // Adjust the path to your theme file
import HomePage from './home/page'; // Your main component or page
import './globals.css'; // Tailwind imports

const App = () => {
  return (
      <HomePage />
  );
};

export default App;
