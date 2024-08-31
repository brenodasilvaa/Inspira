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
    fontFamily: 'Open Sans, Arial, sans-serif'
  }
});

export default theme;
