using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using UnityEngine;

public class Entscheidungen : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject etron;

    [Header("Parts")]
    public GameObject black_window_rs;
    public GameObject carpaint_doors, chrome_logo_r;
    public GameObject chromeBrushed_grill;
    public GameObject glassClear_taillight; 
    public GameObject glassDark_r;
    public GameObject  glassLed_headlight_top;
    public GameObject glassLedB_headlight_side;
    public GameObject glassLens_mirror_cam;
    public GameObject glassRed_taillight;
    public GameObject glassRedIllum_taillight;
    public GameObject grey_plastic_bumper_r;
    public GameObject interiorA_top;
    public GameObject leather_armrest;
    public GameObject leatherB_doors;
    public GameObject plasticB_dashboard;
    public GameObject plasticblack_17;
    public GameObject plasticblack_trunk_top;
    public GameObject plasticGlossy_bumper_r;
    public GameObject plasticGlossy_pillars;
    public GameObject plasticInt_windows;
    public GameObject reflect_taillight_03;
    public GameObject silver_roof;
    public GameObject texInt_dashboard;
    public GameObject brakedisc_001;
    public GameObject metalDark_001;
    public GameObject metalYellow_brakecalliper_001;
    public GameObject rimBright_001;
    public GameObject rimDark_001;
    public GameObject tyre_001;
    public GameObject white_etron;
    public GameObject white_etron001;
    public GameObject yellow_etron;

    [Header("Materials")]
    public Material black;
    public Material carpaint;
    public Material chrome;
    public Material chrome_brushed_brakedisc;
    public Material chrome_brushed;
    public Material glass_clear;
    public Material glass_dark;
    public Material glass_led;
    public Material glass_ledB;
    public Material glass_lens;
    public Material glass_red;
    public Material glass_red_illum;
    public Material intr;
    public Material interiorA;
    public Material leather;
    public Material leatherB;
    public Material plastic_int;
    public Material plasticBB;
    public Material plasticblack;
    public Material plasticblackD;
    public Material plasticGlossy;
    public Material reflect;
    public Material rimB;
    public Material rimDark;
    public Material silver;
    public Material white;
    public Material transparent_mat; 

    [Header("Settings")]
    public bool toggle;

    void Start()
    {
        toggle = false;
    }

    public void OnClick()
    {
        toggle = !toggle;
        etron.GetComponent<BoxCollider>().enabled = !toggle;
        //GameObject.Find("etron").GetComponent<BoundsControl>().enabled = !toggle;
        etron.GetComponent<BoundsControl>().enabled = !toggle;
    }

    public void Update()
    {
        point1.SetActive(toggle);
        point2.SetActive(toggle);
        point3.SetActive(toggle);
        point4.SetActive(toggle);

        if(toggle)
        {
            black_window_rs.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            carpaint_doors.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            chrome_logo_r.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            chromeBrushed_grill.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            glassClear_taillight.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            glassDark_r.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            glassLed_headlight_top.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            glassLedB_headlight_side.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            glassLens_mirror_cam.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            glassRed_taillight.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            glassRedIllum_taillight.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            grey_plastic_bumper_r.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            interiorA_top.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            leather_armrest.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            leatherB_doors.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            plasticB_dashboard.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            plasticblack_trunk_top.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            plasticGlossy_bumper_r.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            plasticGlossy_pillars.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            plasticInt_windows.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            reflect_taillight_03.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            silver_roof.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            texInt_dashboard.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            white_etron.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            white_etron001.GetComponent<Renderer>().sharedMaterial = transparent_mat;
            yellow_etron.GetComponent<Renderer>().sharedMaterial = transparent_mat;
        }
        else
        {
            black_window_rs.GetComponent<Renderer>().sharedMaterial = plasticblack;
            carpaint_doors.GetComponent<Renderer>().sharedMaterial = carpaint;
            chrome_logo_r.GetComponent<Renderer>().sharedMaterial = chrome;
            chromeBrushed_grill.GetComponent<Renderer>().sharedMaterial = chrome_brushed;
            glassClear_taillight.GetComponent<Renderer>().sharedMaterial = glass_clear;
            glassDark_r.GetComponent<Renderer>().sharedMaterial = glass_dark;
            glassLed_headlight_top.GetComponent<Renderer>().sharedMaterial = glass_led;
            glassLedB_headlight_side.GetComponent<Renderer>().sharedMaterial = glass_ledB;
            glassLens_mirror_cam.GetComponent<Renderer>().sharedMaterial = glass_lens;
            glassRed_taillight.GetComponent<Renderer>().sharedMaterial = glass_red;
            glassRedIllum_taillight.GetComponent<Renderer>().sharedMaterial = glass_red_illum;
            grey_plastic_bumper_r.GetComponent<Renderer>().sharedMaterial = rimB;
            interiorA_top.GetComponent<Renderer>().sharedMaterial = interiorA;
            leather_armrest.GetComponent<Renderer>().sharedMaterial = leatherB;
            leatherB_doors.GetComponent<Renderer>().sharedMaterial = leather;
            plasticB_dashboard.GetComponent<Renderer>().sharedMaterial = plasticblackD;
            plasticblack_trunk_top.GetComponent<Renderer>().sharedMaterial = plasticblack;
            plasticGlossy_bumper_r.GetComponent<Renderer>().sharedMaterial = plasticblack;
            plasticGlossy_pillars.GetComponent<Renderer>().sharedMaterial = plasticGlossy;
            plasticInt_windows.GetComponent<Renderer>().sharedMaterial = plastic_int;
            reflect_taillight_03.GetComponent<Renderer>().sharedMaterial = reflect;
            silver_roof.GetComponent<Renderer>().sharedMaterial = silver;
            texInt_dashboard.GetComponent<Renderer>().sharedMaterial = intr;
            white_etron.GetComponent<Renderer>().sharedMaterial = white;
            white_etron001.GetComponent<Renderer>().sharedMaterial = white;
        }
    }
}
