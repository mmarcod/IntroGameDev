using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour
{
    public GameObject settingsPanel = null;
    public GameObject levelSelectPanel = null;
    public GameObject temperaturePanel = null;
    public GameObject helpPanel = null;
    public GameObject detailsPanel = null;
    public GameObject PrimaryPanel = null;
    public void OpensettingsPanel()
    {
        settingsPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
        temperaturePanel.SetActive(false);
        helpPanel.SetActive(false);
        detailsPanel.SetActive(false);
        PrimaryPanel.SetActive(false);
    }
    public void OpentemperaturePanel()
    {
        settingsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
        temperaturePanel.SetActive(true);
        helpPanel.SetActive(false);
        detailsPanel.SetActive(false);
        PrimaryPanel.SetActive(false);
    }
    public void OpenhelpPanel()
    {
        settingsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
        temperaturePanel.SetActive(false);
        helpPanel.SetActive(true);
        detailsPanel.SetActive(false);
        PrimaryPanel.SetActive(false);
    }
    public void OpendetailsPanel()
    {
        settingsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
        temperaturePanel.SetActive(false);
        helpPanel.SetActive(false);
        detailsPanel.SetActive(true);
        PrimaryPanel.SetActive(false);
    }
    public void OpenMainPanel()
    {
        settingsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
        temperaturePanel.SetActive(false);
        helpPanel.SetActive(false);
        detailsPanel.SetActive(false);
        PrimaryPanel.SetActive(true);
    }
    public void OpenLevelSelectPanel()
    {
        settingsPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
        temperaturePanel.SetActive(false);
        helpPanel.SetActive(false);
        detailsPanel.SetActive(false);
        PrimaryPanel.SetActive(false);
    }

}
