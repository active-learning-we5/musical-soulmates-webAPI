import React, { useState, useEffect } from 'react';
import axios from 'axios';

const LanguageSelect = () => {
  const [languages, setLanguages] = useState([]);
  const [selectedLanguage, setSelectedLanguage] = useState('');

  useEffect(() => {
    // Fetch supported languages from the API
    axios.get('/api/languages')
      .then(response => {
        setLanguages(response.data);
        setSelectedLanguage(response.data[0].id); // Set default selected language
      })
      .catch(error => {
        console.error('Error fetching languages:', error);
      });
  }, []);

  const handleLanguageChange = (event) => {
    setSelectedLanguage(event.target.value);
    // Save selected language in local storage or session storage
    localStorage.setItem('selectedLanguage', event.target.value);
    // You can also make an API call to update the user's language preference on the server
  };

  return (
    <div>
      <select value={selectedLanguage} onChange={handleLanguageChange}>
        {languages.map((language) => (
          <option key={language.id} value={language.id}>
            {language.name}
          </option>
        ))}
      </select>
    </div>
  );
};

export default LanguageSelect;