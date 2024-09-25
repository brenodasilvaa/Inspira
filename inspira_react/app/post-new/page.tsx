// pages/music-search.js
import React from 'react';
import { Box, Grid, TextField, Divider, InputAdornment, Typography } from '@mui/material';
import SearchIcon from '@mui/icons-material/Search';

const MusicSearchPage = () => {
  return (
    <Box sx={{ marginTop: '20vh', marginLeft:"5vw", marginRight:"5vw", marginBottom:"20vh" }}>
      <Grid container spacing={2} justifyContent={"space-between"}>
        <Grid item xs={12} md={5}>
          <Typography variant="h6" textAlign="center" gutterBottom>
            Música original
          </Typography>
          <Box component="form" noValidate autoComplete="off">
            <TextField 
              label="Buscar música" 
              variant="outlined" 
              fullWidth
              InputProps={{
                startAdornment: (
                  <InputAdornment position="start">
                    <SearchIcon />
                  </InputAdornment>
                ),
              }}
            />
          </Box>
        </Grid>

        <Grid item xs={12} md={0.3} display={{ xs: 'none', md: 'block' }}>
          <Divider orientation="vertical" />
        </Grid>

        <Grid item xs={12} md={5}>
          <Typography variant="h6" textAlign="center" gutterBottom>
            Música inspirada
          </Typography>
          <Box component="form" noValidate autoComplete="off">
            <TextField 
              label="Buscar música" 
              variant="outlined" 
              fullWidth
              InputProps={{
                startAdornment: (
                  <InputAdornment position="start">
                    <SearchIcon />
                  </InputAdornment>
                ),
              }}
            />
          </Box>
        </Grid>
      </Grid>

      <Box mt={4}>
        <TextField 
          label="Descrição" 
          variant="outlined" 
          fullWidth 
        />
      </Box>
    </Box>
  );
};

export default MusicSearchPage;
