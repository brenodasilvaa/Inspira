'use client';

import { createTheme } from '@mui/material/styles';
import './globals.css';

const theme = createTheme({
  palette: {
    primary: {
      main: '#111111',
    },
  },
  typography: {
    body2: {
      fontSize: '0.8rem',    // Set your base font size
    },
    body1: {
      fontSize: '0.8rem',    // Set your base font size
    },
    subtitle1: {
      fontSize: '0.8rem',    // Set your base font size
    },
    subtitle2: {
      fontSize: '0.8rem',    // Set your base font size
    },
    fontFamily: 'Open Sans, Arial, sans-serif'
  }
});

export default theme;
