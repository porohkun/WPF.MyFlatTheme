﻿using System.Windows;
using System.Windows.Media;

namespace WPF.Misc
{
    public class PathDecorator : DependencyObject
    {
        #region PathStyle

        public static readonly DependencyProperty PathStyleProperty = DependencyProperty.RegisterAttached(
            "PathStyle",
            typeof(Style),
            typeof(PathDecorator),
            new PropertyMetadata(null));

        public static void SetPathStyle(DependencyObject element, Style value)
        {
            element.SetValue(PathStyleProperty, value);
        }

        public static Style GetPathStyle(DependencyObject element)
        {
            return (Style)element.GetValue(PathStyleProperty);
        }

        #endregion //PathStyle

        #region PathThickness

        public static readonly DependencyProperty PathThicknessProperty = DependencyProperty.RegisterAttached(
            "PathThickness",
            typeof(double),
            typeof(PathDecorator),
            new PropertyMetadata(0d));

        public static void SetPathThickness(DependencyObject element, double value)
        {
            element.SetValue(PathThicknessProperty, value);
        }

        public static double GetPathThickness(DependencyObject element)
        {
            return (double)element.GetValue(PathThicknessProperty);
        }

        #endregion //PathThickness

        #region PathWidth

        public static readonly DependencyProperty PathWidthProperty = DependencyProperty.RegisterAttached(
            "PathWidth",
            typeof(double),
            typeof(PathDecorator),
            new PropertyMetadata(double.NaN));

        public static void SetPathWidth(DependencyObject element, double value)
        {
            element.SetValue(PathWidthProperty, value);
        }

        public static double GetPathWidth(DependencyObject element)
        {
            return (double)element.GetValue(PathWidthProperty);
        }

        #endregion //PathWidth

        #region PathHeight

        public static readonly DependencyProperty PathHeightProperty = DependencyProperty.RegisterAttached(
            "PathHeight",
            typeof(double),
            typeof(PathDecorator),
            new PropertyMetadata(double.NaN));

        public static void SetPathHeight(DependencyObject element, double value)
        {
            element.SetValue(PathHeightProperty, value);
        }

        public static double GetPathHeight(DependencyObject element)
        {
            return (double)element.GetValue(PathHeightProperty);
        }

        #endregion //PathThickness

        #region PathRenderTransform

        public static readonly DependencyProperty PathRenderTransformProperty = DependencyProperty.RegisterAttached(
            "PathRenderTransform",
            typeof(Transform),
            typeof(PathDecorator),
            new PropertyMetadata(default(Transform)));

        public static void SetPathRenderTransform(DependencyObject element, Transform value)
        {
            element.SetValue(PathRenderTransformProperty, value);
        }

        public static Transform GetPathRenderTransform(DependencyObject element)
        {
            return (Transform)element.GetValue(PathRenderTransformProperty);
        }

        #endregion //PathRenderTransform
    }
}
